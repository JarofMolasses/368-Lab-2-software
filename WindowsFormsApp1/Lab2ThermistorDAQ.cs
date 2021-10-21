using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form2 : Form
    {
        StreamWriter outFile;

        ConcurrentQueue<Int32> bufferQueue = new ConcurrentQueue<Int32>();
        Int32 dequeueOut; 
        ConcurrentQueue<float> voltsQueue = new ConcurrentQueue<float>();        // ADC converted voltages 
        ConcurrentQueue<float> tempQueue = new ConcurrentQueue<float>();         // Computed temperatures
        ConcurrentQueue<float> tempAvgQueue = new ConcurrentQueue<float>();      // Copy of temperatures queue for a rolling average 

        
        static int tempWindowSize = 500;                                        // This is the memory depth for the graphical display: display this many temperature points
        int rollingAvgSize = 300;                                               // number of samples for rolling average calculation
        float trash;                                                            // dequeue into this trash to maintain windowsize items in quueue
        float[] tempDisplayCopyArray = new float[tempWindowSize];               // copy tempQueue into this array for live grapihng at each frame

        int byteState = -1;                // 0 = waiting, 1 = MSB, 2 = LSB
        
        int ms5b;                           // we need to put these declarations as class variables or else the timer tick would reset them at strange times and mess up the reading
        int ls5b;

        float Vcc = 3.651F;                 // measured with UT139C 
        Int32 analogRes = 1023;
                
        public Form2()
        {
            InitializeComponent();

            // initialize chart
            chart1.Titles.Add($"Temperature (K), last {tempWindowSize} samples");
            this.chart1.Series.Clear();
            chart1.Series.Add("T(K)");
            chart1.Series["T(K)"].ChartType = SeriesChartType.Line;             // make sure it's a line chart.

            rollingAvgSizeTextBox.Text = rollingAvgSize.ToString();

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Int32 bytesToRead = serialPort1.BytesToRead;
            Int32 newByte;

            while (bytesToRead != 0)
            {

                newByte = serialPort1.ReadByte();
                bufferQueue.Enqueue(newByte); 
                bytesToRead = serialPort1.BytesToRead;

            }
        }

        private float convertVoltsToTemperature(float volts)
        {
            float Rref = 10000;     // the reference resistor
            float R0 = 10000;       // R0 for the thesmistor
            float T0 = 298;         // T0 for the thermistor, in K
            float beta = 3435;
            float Vref = Vcc;

            float Rthermistor = Rref / (Vref / volts - 1);
            return 1 / ((float)Math.Log(Rthermistor / R0)/beta + 1 / T0);
        }

        private void updateChart()
        {
            chart1.Series["T(K)"].Points.Clear();
          
            tempQueue.CopyTo(tempDisplayCopyArray, 0);          // snapshot of the queue at this time, copy to an array
            for(int i = 0; i < tempQueue.Count; i ++)
            {
                float tempOut = tempDisplayCopyArray[i];
                chart1.Series["T(K)"].Points.AddXY(i, tempOut);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";          // this is the default MSP430 port 
          
            comPortDropdown.Items.Clear();
            comPortDropdown.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comPortDropdown.Items.Count == 0)
            {
                comPortDropdown.Text = "No COM ports found";
            }
            else
            {
                comPortDropdown.SelectedIndex = 0;
            }
        }

        private void connectSerialButton_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                connectSerialButton.Text = "Disconnect serial";
                serialPort1.Open();
                serialPort1.Write("c");
            }
            else
            {
                connectSerialButton.Text = "Connect serial";
                serialPort1.Close();

                saveFileCheckBox.Checked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(serialPort1.IsOpen)
            {
                foreach(Int32 bufferItem in bufferQueue)
                {
                    bufferQueue.TryDequeue(out dequeueOut); 

                    if(dequeueOut == 255)
                    {
                        byteState = 0;
                    }

                    switch (byteState)
                    {
                        case 0:
                            Console.Write($"start={Convert.ToString(bufferItem, 10)}, ");
                            byteState = 1;
                            break;

                        case 1:
                            ms5b = bufferItem;                   // store MS5B
                            Console.Write($"MS5B={Convert.ToString(ms5b, 10)}, ");
                            byteState = 2;
                            break;

                        case 2:
                            ls5b = bufferItem;                   // store LS5B
                            Console.Write($"LS5B={Convert.ToString(bufferItem, 10)}, ");

                            int adcReading = (ms5b << 5) | ls5b;                        // add MSB << 5 and LSB to reconstruct ADC reading
                            float voltage = Vcc * (adcReading / (float)analogRes);      // compute voltage
                            voltsQueue.Enqueue(voltage);                                // store voltage
                            thermistorVDisplay.Text = voltage.ToString();               

                            float temp = convertVoltsToTemperature(voltage);            // convert voltage to temperature
                            tempQueue.Enqueue(temp);                                    // store temperature in both raw and avg queues
                            tempAvgQueue.Enqueue(temp);
                            temperatureKDisplay.Text = temp.ToString();
                            temperatureCDisplay.Text = (temp - 273.15).ToString();

                            float tempAvg = tempAvgQueue.Average();                        // take the average 
                            tempKRollingAvgDisplay.Text = tempAvg.ToString();
                            
                            if(tempQueue.Count > tempWindowSize)
                            {
                                tempQueue.TryDequeue(out trash);    // keeps the temp queue at tempWindowSize items
                            }
                            if(tempAvgQueue.Count > rollingAvgSize)
                            {
                                tempAvgQueue.TryDequeue(out trash);     // keeps the avg queue at rollingAvgSize items
                            }

                            if(saveFileCheckBox.Checked)            
                            {
                                outFile.Write($"{DateTime.Now.ToString("HH.mm.ss")},{temp.ToString()}\n");
                            }
                            Console.WriteLine($"  {adcReading} counts, {voltage} V, {temp} K");

                            break;

                        default:
                            break;
                    }
                }

                updateChart();
                
            }
        }

        private void saveFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saveFileCheckBox.Checked)
            {
                try
                {
                    if (!fileNameTextBox.Text.EndsWith(".csv"))
                    {
                        fileNameTextBox.Text += ".csv";
                    }
                    outFile = new StreamWriter($"{ fileNameTextBox.Text }");         // auto append .csv
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("File path is empty");
                    saveFileCheckBox.Checked = false;
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("File is currently open");
                    saveFileCheckBox.Checked = false;
                }
                finally
                {

                }
            }

            else
            {
                try { outFile.Close(); }
                catch { }
            }
        }

        private void selectFileButton_MouseClick(object sender, MouseEventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileNameTextBox.Text = saveFileDialog1.FileName;
        }

        private void comPortDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comPortDropdown.Text;
        }

        private void updateRollingAvgButton_MouseClick(object sender, MouseEventArgs e)
        {
            rollingAvgSize = Convert.ToInt32(rollingAvgSizeTextBox.Text);            // allow for on the fly average window editing
            if (rollingAvgSize > tempWindowSize)
            {
                rollingAvgSizeTextBox.Clear();
                rollingAvgSize = tempWindowSize;
                MessageBox.Show("Rolling avg size capped at temp window size");
                rollingAvgSizeTextBox.Text = tempWindowSize.ToString();
            }
        }
    }
}
