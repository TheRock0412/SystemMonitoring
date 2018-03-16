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
    public partial class FormInternet : Form
    {
        private Thread sendenThread;
        private double[] sendenArray = new double[60];

        private Thread empfangenThread;
        private double[] empfangenArray = new double[60];

        public FormInternet()
        {
            InitializeComponent();

            metroLabel2.Text = Hardware.Internet.GetNetworkAdapter();
            metroLabel4.Text = Hardware.Internet.GetVerbindungstyp();
            metroLabel6.Text = Hardware.Internet.GetDNSSurffix();
            metroLabel8.Text = Hardware.Internet.GetIPAddress4();
            metroLabel10.Text = Hardware.Internet.GetIPAddress6();
            metroLabel12.Text = Hardware.Internet.GetMACAddress();

        }

        public void getPerformanceCountersSenden()
        {
            var sendenPerfCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", "Intel[R] 82579LM Gigabit Network Connection");

            while (true)
            {
                sendenArray[sendenArray.Length - 1] = Math.Round(sendenPerfCounter.NextValue() / 100, 0);

                Array.Copy(sendenArray, 1, sendenArray, 0, sendenArray.Length - 1);

                if (InternetChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateSendenChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        public void UpdateSendenChart()
        {
            InternetChart.Series["Senden_Usage"].Points.Clear();

            for (int i = 0; i < sendenArray.Length - 1; ++i)
            {
                InternetChart.Series["Senden_Usage"].Points.AddY(sendenArray[i]);
            }
        }

        public void getPerformanceCountersEmpfangen()
        {
            var empfangenPerfCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", "Intel[R] 82579LM Gigabit Network Connection");

            while (true)
            {
                empfangenArray[empfangenArray.Length - 1] = Math.Round(empfangenPerfCounter.NextValue() / 100, 0);

                Array.Copy(empfangenArray, 1, empfangenArray, 0, empfangenArray.Length - 1);

                if (InternetChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateEmpfangenChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        public void UpdateEmpfangenChart()
        {
            InternetChart.Series["Empfangen_Usage"].Points.Clear();

            for (int i = 0; i < empfangenArray.Length - 1; ++i)
            {
                InternetChart.Series["Empfangen_Usage"].Points.AddY(empfangenArray[i]);
            }
        }


        private void FormInternet_Load(object sender, EventArgs e)
        {
            sendenThread = new Thread(new ThreadStart(this.getPerformanceCountersSenden));
            sendenThread.IsBackground = true;
            sendenThread.Start();
            
            empfangenThread = new Thread(new ThreadStart(this.getPerformanceCountersEmpfangen));
            empfangenThread.IsBackground = true;
            empfangenThread.Start();

            InternetChart.ChartAreas[0].AxisY.Maximum = 500;
            InternetChart.ChartAreas[0].AxisY.Minimum = 0;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fsenden = perSenden.NextValue() / 100;
            float fempfangen = perEmpfangen.NextValue() / 100;

            metroLabel14.Text = string.Format("{0:0} KBits/s", fsenden);
            metroLabel16.Text = string.Format("{0:0} KBits/s", fempfangen);
        }
    }
}
