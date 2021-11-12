using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var rand = new Random();
            int randMillis = rand.Next(1000, 10000);

            timer1.Interval = randMillis;
            timerDisplay.Text = (randMillis/(float)1000).ToString();
            Console.WriteLine($"Next interval: {randMillis} millisecond");

            if(serialPort1.IsOpen)
            {
                serialPort1.Write("5");
                Thread.Sleep(500);          // wait 500 msec
                serialPort1.Write("%");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialPort1.PortName = "COM3";      // lazy, the MSP430 defaults to this
            serialPort1.Open();
        }
    }
}
