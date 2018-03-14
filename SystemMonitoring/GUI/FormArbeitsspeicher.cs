using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormArbeitsspeicher : Form
    {
        private Thread ramThread;
        private double[] ramArray = new double[60];

        public FormArbeitsspeicher()
        {
            InitializeComponent();
        }

        private void getPerformanceCountersRAM()
        {
            var ramPerfCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");

            while (true)
            {
                ramArray[ramArray.Length - 1] = Math.Round(ramPerfCounter.NextValue(), 0);

                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);

                if (ramChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateRamChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateRamChart()
        {
            ramChart.Series["RAM_Usage"].Points.Clear();

            for (int i = 0; i < ramArray.Length - 1; ++i)
            {
                ramChart.Series["RAM_Usage"].Points.AddY(ramArray[i]);
            }
        }

        private void FormArbeitsspeicher_Load(object sender, EventArgs e)
        {
            ramThread = new Thread(new ThreadStart(this.getPerformanceCountersRAM));
            ramThread.IsBackground = true;
            ramChart.ChartAreas[0].AxisY.Maximum = 100;
            ramChart.ChartAreas[0].AxisY.Minimum = 0;
            ramThread.Start();
        }
    }
}
