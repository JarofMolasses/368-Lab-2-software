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
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add($"Last {DISPLAY_BUFFER_SIZE} samples");
            this.chart1.Series.Clear();
            chart1.Series.Add("V");

            chart1.Series["V"].ChartType = SeriesChartType.Line;             // make sure it's a line chart.

            chart1.Series["V"].Color = Color.Red;
        }
        static Int32 DISPLAY_BUFFER_SIZE = 500;
        Int32 ROLLING_AVG_SIZE = 200;
        Int32 SDEV_SIZE = 1000;
        double distLow = 3;
        double distHigh = 18;

        ConcurrentQueue<Int32> bufferQueue = new ConcurrentQueue<Int32>();
        Int32 dequeueOut;                                                       // temp variable to store dequeued values from buffer
        ConcurrentQueue<double> voltsQueue = new ConcurrentQueue<double>();

        ConcurrentQueue<double> distQueue = new ConcurrentQueue<double>();
        ConcurrentQueue<double> distQueueAvg = new ConcurrentQueue<double>();
        ConcurrentQueue<double> distQueueSdev = new ConcurrentQueue<double>();  // for taking RMS noise measurements

        double[] voltsGraphArray = new double[DISPLAY_BUFFER_SIZE];

        double distSumSquares = 0;                                             // track sum of squares for sdev
        double trash;


        int byteState = -1;

        int ms5b;                           // we need to put these declarations as class variables or else the timer tick would reset them at strange times and mess up the reading
        int ls5b;


        double Vcc = 3.651;                 // measured with UT139C 
        Int32 analogRes = 1023;

        private void Form1_Load(object sender, EventArgs e)
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

        private void connectSerialButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                connectSerialButton.Text = "Disconnect serial";
                serialPort1.Open();
                serialPort1.Write("c");
            }
            else
            {
                connectSerialButton.Text = "Connect serial";
                serialPort1.Close();
            }
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

        private void comPortDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)                 // if port is open, you can't change the port name. Nor would you want to, lol
            {
                serialPort1.PortName = comPortDropdown.Text;
            }
        }

        private double voltsToDist(double volts)    // dist in centimeters
        {
            double A = 4.9932;
            double B = -0.551;
            return A* Math.Pow(volts, B);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                foreach (Int32 bufferItem in bufferQueue)
                {
                    bufferQueue.TryDequeue(out dequeueOut);

                    if (dequeueOut == 255)
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
                            double voltage = Vcc * (adcReading / (double)analogRes);      // compute voltage
                            voltsQueue.Enqueue(voltage);                                // store voltage
                            voltsDisplay.Text = voltage.ToString();

                            double dist = voltsToDist(voltage);

                            distQueue.Enqueue(dist);                                    // store dist in both queues
                            distQueueAvg.Enqueue(dist);
                            distQueueSdev.Enqueue(dist);
                            distSumSquares += dist * dist;

                            distDisplay.Text = dist.ToString();

                            double distAvg = distQueueAvg.Average();                        // take the average of the average queue

                            if (distAvg < distHigh && distAvg > distLow)
                            {
                                distDisplayAvg.Text = (distAvg).ToString("##0.000");          // adjust final reading with distOffset
                            } else
                            {
                                distDisplayAvg.Text = "Out of range";
                            }
                            if (voltsQueue.Count > DISPLAY_BUFFER_SIZE)
                            {
                                voltsQueue.TryDequeue(out trash);
                            }
                            if (distQueue.Count > DISPLAY_BUFFER_SIZE)
                            {
                                distQueue.TryDequeue(out trash);                           // keeps the dist queue at DISPLAY_BUFFER_SIZE items
                            }
                            if (distQueueAvg.Count > ROLLING_AVG_SIZE)
                            {
                                distQueueAvg.TryDequeue(out trash);                       // keeps the avg queue at ROLLING_AVG_SIZE items
                            }
                            if (distQueueSdev.Count > SDEV_SIZE)
                            {
                                distQueueSdev.TryDequeue(out trash);
                                distSumSquares -= trash * trash;
                            }

                            double distAvgSdev = distQueueSdev.Average();
                            double sdev = Math.Sqrt((distSumSquares / SDEV_SIZE - distAvgSdev * distAvgSdev));
                            sdevDisplay.Text = sdev.ToString();

                            Console.WriteLine($"  {adcReading} counts, {voltage} V, {dist} cm, {sdev}");

                            break;

                        default:
                            break;
                    }
                }

                updateChart();

            }
        }

        private void updateChart()
        {
            chart1.Series["V"].Points.Clear();

            voltsQueue.CopyTo(voltsGraphArray, 0);          // snapshot of the queue at this time, copy to an array

            for (int i = 0; i < voltsQueue.Count; i++)
            {
                chart1.Series["V"].Points.AddXY(i, voltsGraphArray[i]);
            }
        }
    }
}
