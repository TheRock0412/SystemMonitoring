using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormInternet : Form
    {
        private Thread ThreadSend;
        private double[] SendArray = new double[60];

        private Thread ThreadReceive;
        private double[] ReceiveArray = new double[60];

        Hardware.Internet internet = new Hardware.Internet();

        public FormInternet()
        {
            InitializeComponent();

            mlInternetAdapter_Value.Text = internet.GetNetworkAdapter();
            mlConnectionType_Value.Text = internet.GetVerbindungstyp();
            mlDNS_Value.Text = internet.GetDNSSurffix();
            mlIP4_Value.Text = internet.GetIPAddress4();
            mlIP6_Value.Text = internet.GetIPAddress6();
            mlPhyiscalAdress_Value.Text = internet.GetMACAddress();
            mlGateway_Value.Text = internet.GetGateway();
        }

        public void getPerformanceCountersSend()
        {
            var sendPerfCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", internet.GetNetworkAdapter());

            while (true)
            {
                SendArray[SendArray.Length - 1] = Math.Round(sendPerfCounter.NextValue() / 100, 0);

                Array.Copy(SendArray, 1, SendArray, 0, SendArray.Length - 1);

                if (InternetChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateSendChart(); });
                }
                else
                {
                    //......
                }
                Thread.Sleep(1000);
            }
        }

        public void UpdateSendChart()
        {
            InternetChart.Series["Senden_Usage"].Points.Clear();

            for (int i = 0; i < SendArray.Length - 1; ++i)
            {
                InternetChart.Series["Senden_Usage"].Points.AddY(SendArray[i]);
                mlSend_Value.Text = string.Format("{0:0} KBit/s", SendArray[i]);
            }
        }

        public void getPerformanceCountersReceived()
        {
            var empfangenPerfCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", internet.GetNetworkAdapter());

            while (true)
            {
                ReceiveArray[ReceiveArray.Length - 1] = Math.Round(empfangenPerfCounter.NextValue() / 100, 0);

                Array.Copy(ReceiveArray, 1, ReceiveArray, 0, ReceiveArray.Length - 1);

                if (InternetChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateReceiveChart(); });
                }
                else
                {
                    //......
                }
                Thread.Sleep(1000);
            }
        }

        public void UpdateReceiveChart()
        {
            InternetChart.Series["Empfangen_Usage"].Points.Clear();

            for (int i = 0; i < ReceiveArray.Length - 1; ++i)
            {
                InternetChart.Series["Empfangen_Usage"].Points.AddY(ReceiveArray[i]);
                mlReceive_Value.Text = string.Format("{0:0} KBit/s", ReceiveArray[i]);
            }
        }

        private void FormInternet_Load(object sender, EventArgs e)
        {
            ThreadSend = new Thread(new ThreadStart(this.getPerformanceCountersSend));
            ThreadSend.IsBackground = true;
            ThreadSend.Start();

            ThreadReceive = new Thread(new ThreadStart(this.getPerformanceCountersReceived));
            ThreadReceive.IsBackground = true;
            ThreadReceive.Start();

            InternetChart.ChartAreas[0].AxisX.RoundAxisValues();
            InternetChart.ChartAreas[0].AxisY.RoundAxisValues();
        }
    }
}
