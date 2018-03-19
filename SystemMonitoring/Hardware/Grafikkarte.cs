using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace SystemMonitoring.Hardware
{
    class Grafikkarte
    {
        public Grafikkarte()
        {

        }

        public static string GPUName(string name, string syntax)
        {
            String gpuName = string.Empty; ;

            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + name);
            foreach (ManagementObject nj in mos.Get())
            {
                if (gpuName == String.Empty)
                {
                    gpuName = Convert.ToString(nj[syntax]);
                }
                else
                {
                    MessageBox.Show("GPU Name nicht gefunden!");
                }
            }
            return gpuName;
        }

        //private void button1_Click(object sender, EventArgs e) { GetComponent("Win32_Processor", "Name"); GetComponent("Win32_VideoController", "Name"); }
        //private void GetComponent(string hwclass, string syntax) { ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
        //    //foreach (ManagementObject mj in mos.Get()) { textBox1.AppendText((Convert.ToString(mj[syntax])) + "\r\n"); } }

    }
}
