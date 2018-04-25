using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormMemory : Form
    {
        private Thread MemoryThread, FreeMemoryThread;
        private double[] MemoryArray = new double[60];
        private float[] FreeMemoryArray = new float[1];

        Hardware.Memory memory = new Hardware.Memory();

        public FormMemory()
        {
            InitializeComponent();

            //mlFreeMemory_Value.Text = memory.GetFreeMemory();
            mlMemorySize_Value.Text = string.Format("{0:0.0} GB", memory.GetTotalMemory());
            //mlMemoryCommitted_Value.Text = memory.GetMemoryType().ToString();
            mlPartNumber_Value.Text = memory.GetPartNumber();
            mlManufacturer_Value.Text = memory.GetManufacturer();
            //mlSerialNumber_Value.Text = memory.GetSerialNumber();
        }

        private void getPerformanceCounterFreeMemory()
        {
            var freeMermoryPerfCounter = new PerformanceCounter("Memory", "Available Bytes");

            while (true)
            {

            }
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
                // mlMemoryCommitted_Value.Text = string.Format("{0:000000} GB", MemoryArray[i]);
                mlMemoryCommitted_Value.Text = MemoryArray[i].ToString();
                //mlFreeMemory_Value.Text = string.Format("{0:0} GB",  (MemoryArray[i] - memory.GetTotalMemory()) / 1024);
            }
        }

        private void GetUpdateFreeMemory()
        {
            while (true)
            {
                memory.GetFreeMemory();

                if (memory.GetFreeMemory() > 1000)
                {
                    string GetFreeMomoryGB = Convert.ToString(memory.GetFreeMemory() / 1024);
                    Console.WriteLine(GetFreeMomoryGB);
                    this.Invoke((MethodInvoker)delegate { mlFreeMemory_Value.Text = string.Format("{0:0.0} GB", GetFreeMomoryGB); });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate { mlFreeMemory_Value.Text = string.Format("{0:000} MB", memory.GetFreeMemory().ToString()); });
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

            MemoryChart.ChartAreas[0].AxisY.Maximum = 100;
            MemoryChart.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}
