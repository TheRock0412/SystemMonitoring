﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormCPU : Form
    {
        private Thread cpuThread;
        private double[] cpuArray = new double[60];

        Hardware.CPU cpu = new Hardware.CPU();

        public FormCPU()
        {
            InitializeComponent();

            mlCPUName_Value.Text = Hardware.CPU.CPUName;
            
        }

        public void getPerformanceCountersCPU()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }

        public void UpdateCpuChart()
        {
            //double CPUSpeed = cpu.CPUSpeed() / 1000;
            mlCPUSpeed_Value.Text = cpu.CPUSpeed(); //string.Format("{0:0.00} GHz", CPUSpeed);

            cpuChart.Series["CPU_Usage"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart.Series["CPU_Usage"].Points.AddY(cpuArray[i]);
                mlCPUInVerwendung_Value.Text = string.Format("{0:0} %", cpuArray[i]);
            }
        }

        private void FormCPU_Load(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformanceCountersCPU));
            cpuThread.IsBackground = true;
            cpuThread.Start();
            cpuChart.ChartAreas[0].AxisY.Maximum = 100;
            cpuChart.ChartAreas[0].AxisY.Minimum = 0;
        }
    }
}
