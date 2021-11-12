

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


namespace Lab_3
{ 
    public partial class Lab3Scale : Form
    {
        static Int32 DISPLAY_BUFFER_SIZE = 500;
        Int32 ROLLING_AVG_SIZE = 200;
        Int32 SDEV_SIZE = 200;                   // 500ms for stability

        public Lab3Scale()
        {
            InitializeComponent();


            // initialize chart
            chart1.Titles.Add($"Mass (kg), last {DISPLAY_BUFFER_SIZE} samples");
            chart1.Titles[0].ForeColor = Color.White;
            this.chart1.Series.Clear();
            chart1.Series.Add("Mass");
            chart1.Series["Mass"].ChartType = SeriesChartType.Line;             // make sure it's a line chart.
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkSlateGray;
        }

        ConcurrentQueue<Int32> bufferQueue = new ConcurrentQueue<Int32>();
        Int32 dequeueOut;                                                       // temp variable to store dequeued values from buffer

        ConcurrentQueue<double> voltsQueue = new ConcurrentQueue<double>();
        ConcurrentQueue<double> massQueue = new ConcurrentQueue<double>();
        ConcurrentQueue<double> massQueueAvg = new ConcurrentQueue<double>();     // rolling average queue. it's just a copy of massQueue but we can limit the size of this one to whatever we want before taking the average.
        ConcurrentQueue<double> massQueueSdev = new ConcurrentQueue<double>();

        double[] massGraphArray = new double[DISPLAY_BUFFER_SIZE];                // snapshot array for graphing. It's one way to do it.
        double massSumOfSquares = 0;                                             // track mass sum of squares for sdev
        double stabilityThres = 0.005;                                             // sdev threshold for a stable reading
        double massOffset = 0;                                                   // tare offset mass              

        double trash;                                                            // dequeue into this trash to maintain windowsize items in queue
        int byteState = -1;                // 0 = waiting, 1 = MSB, 2 = LSB

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

            resizeMassDisplayAvg();
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

        private void comPortDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)                 // if port is open, you can't change the port name. Nor would you want to, lol
            { 
                serialPort1.PortName = comPortDropdown.Text;
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

        private void updateChart()
        {
            chart1.Series["Mass"].Points.Clear();

            massQueue.CopyTo(massGraphArray, 0);          // snapshot of the queue at this time, copy to an array
            for (int i = 0; i < massQueue.Count; i++)
            {
                double massOut = massGraphArray[i] - massOffset;
                chart1.Series["Mass"].Points.AddXY(i, massOut);
            }
        }
        private double convertVoltsToMass(double volts)
        {
            double A = 2.6073;
            double B = -1.0501;

            return A + B * volts;
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

                            double mass = convertVoltsToMass(voltage);                                     // convert voltage to  mass

                            massQueue.Enqueue(mass);                                    // store mass in both queues
                            massQueueAvg.Enqueue(mass);
                            massQueueSdev.Enqueue(mass);
                            massSumOfSquares += mass*mass;

                            massDisplay.Text = mass.ToString();
                       
                            double massAvg = massQueueAvg.Average();                        // take the average of the average queue
                            massDisplayAvgRaw.Text = massAvg.ToString("##0.000");
                            massDisplayAvg.Text = (massAvg - massOffset).ToString("##0.000");          // adjust final reading with massOffset

                            if (massQueue.Count > DISPLAY_BUFFER_SIZE)
                            {
                                massQueue.TryDequeue(out trash);                           // keeps the mass queue at DISPLAY_BUFFER_SIZE items
                            }
                            if (massQueueAvg.Count > ROLLING_AVG_SIZE)
                            {
                                massQueueAvg.TryDequeue(out trash);                       // keeps the avg queue at ROLLING_AVG_SIZE items
                            }
                            if(massQueueSdev.Count > SDEV_SIZE)
                            {
                                massQueueSdev.TryDequeue(out trash);
                                massSumOfSquares -= trash * trash;
                            }

                            double massAvgSdev = massQueueSdev.Average();
                            double sdev = Math.Sqrt((massSumOfSquares / SDEV_SIZE - massAvgSdev*massAvgSdev));
                            sdevDisplay.Text = sdev.ToString();

                            if(sdev > stabilityThres)
                            {
                                kgLabel.ForeColor = Color.Red; 
                            } 
                            else
                            {
                                kgLabel.ForeColor = Color.MintCream;
                            }
                            Console.WriteLine($"  {adcReading} counts, {voltage} V, {mass} kg");

                            break;

                        default:
                            break;
                    }
                }

                updateChart();

            }
        }

        private void tareButton_MouseClick(object sender, MouseEventArgs e)
        {
            massOffset = massQueueAvg.Average();
            massOffsetDisplay.Text = massOffset.ToString();
        }

        private void massDisplayAvg_Resize(object sender, EventArgs e)
        {
            resizeMassDisplayAvg();
        }

        private void resizeMassDisplayAvg()
        {
            Int32 fontHeight = massDisplayAvg.Size.Width / 7;
            massDisplayAvg.Font = new Font("Microsoft Sans Serif", fontHeight);
        }
    }
}
