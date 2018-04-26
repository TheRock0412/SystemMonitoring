using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormMemory : Form
    {
        private Thread MemoryThread, FreeMemoryThread, InUseMemoryThread;
        private double[] MemoryArray = new double[60];

        Hardware.Memory memory = new Hardware.Memory();

        public FormMemory()
        {
            InitializeComponent();

            mlMemorySize_Value.Text = string.Format("{0:0.0} GB", Math.Round(memory.GetTotalMemory() / 1024 / 1024, 2));
            mlPartNumber_Value.Text = memory.GetPartNumber();
            mlManufacturer_Value.Text = memory.GetManufacturer();
            //mlSerialNumber_Value.Text = memory.GetSerialNumber();
        }

        private void getPerformanceCountersMemory()
        {
            var ramPerfCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");

            while (true)
            {
                MemoryArray[MemoryArray.Length - 1] = Math.Round(ramPerfCounter.NextValue(), 0);

                Array.Copy(MemoryArray, 1, MemoryArray, 0, MemoryArray.Length - 1);

                if (MemoryChart.IsHandleCreated)
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
            MemoryChart.Series["RAM_Usage"].Points.Clear();

            for (int i = 0; i < MemoryArray.Length - 1; ++i)
            {
                MemoryChart.Series["RAM_Usage"].Points.AddY(MemoryArray[i]);
            }
        }

        private void GetUpdateFreeMemory()
        {
            while (true)
            {
                float FreeMemoryinKB = memory.GetFreeMemory();

                int FreeMemoryinMB = Convert.ToInt32(FreeMemoryinKB / 1024);
                double FreeMemoryinGB = Math.Round(FreeMemoryinKB / 1024 / 1024, 2);
                
                if (FreeMemoryinMB >= 1000)
                {
                    /* Invoke((MethodInvoker)delegate {*/ mlFreeMemory_Value.Text = string.Format("{0} GB", FreeMemoryinGB); //});
                }
                else
                {
                    /*Invoke((MethodInvoker)delegate {*/ mlFreeMemory_Value.Text = string.Format("{0} MB", FreeMemoryinMB); // });
                }
                Thread.Sleep(1000);
            }         
        }

        private void GetUpdateInUseMemory()
        {
            while (true)
            {
                double InUseMemory =  memory.GetTotalMemory() - memory.GetFreeMemory();

                int InUseMemoryinMB = Convert.ToInt32(InUseMemory / 1024);
                double InUseMemoryinGB = Math.Round(InUseMemory / 1024 / 1024, 2);

                if (InUseMemory >= 10000)
                {
                    //*Invoke((MethodInvoker)*/delegate { mlMemoryCommitted_Value.Text = string.Format("{0} GB", InUseMemoryinGB); } ;//);
                    Invoke(delegate { mlMemoryCommitted_Value.Text = string.Format("{0} GB", InUseMemoryinGB) };);
                }
                else
                {
                    /*Invoke((MethodInvoker)delegate {*/ mlMemoryCommitted_Value.Text = string.Format("{0} MB", InUseMemoryinMB); //});
                }
                Thread.Sleep(1000);
            }
        }

        private void FormArbeitsspeicher_Load(object sender, EventArgs e)
        {
            MemoryThread = new Thread(new ThreadStart(this.getPerformanceCountersMemory));
            MemoryThread.IsBackground = true;
            MemoryThread.Start();

            FreeMemoryThread = new Thread(new ThreadStart(this.GetUpdateFreeMemory));
            FreeMemoryThread.IsBackground = true;
            FreeMemoryThread.Start();

            InUseMemoryThread = new Thread(new ThreadStart(this.GetUpdateInUseMemory));
            InUseMemoryThread.IsBackground = true;
            InUseMemoryThread.Start();

            MemoryChart.ChartAreas[0].AxisY.Maximum = 100;
            MemoryChart.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}