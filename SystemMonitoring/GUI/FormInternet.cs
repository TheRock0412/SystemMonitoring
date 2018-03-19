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
            var sendenPerfCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", Hardware.Internet.GetNetworkAdapter());
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
                metroLabel14.Text = string.Format("{0:0.00} KBit/s", sendenArray[i] / 100);
            }
        }

        public void getPerformanceCountersEmpfangen()
        {
            var empfangenPerfCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", Hardware.Internet.GetNetworkAdapter());

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
                metroLabel16.Text = string.Format("{0:0.00} KBit/s", empfangenArray[i] / 100);
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

            InternetChart.ChartAreas[0].AxisY.Maximum = 100;
            InternetChart.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}
