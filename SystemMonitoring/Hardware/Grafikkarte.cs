using System;
using System.Diagnostics;
using System.Management;


namespace SystemMonitoring.Hardware
{
    class Grafikkarte
    {



        public Grafikkarte()
        {
            //asdf("Win32_VideoController", "Name");
        }

        public static string Asdf()
        {
            String name = "";

            //    //////ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + test);
            //    //////foreach (ManagementObject nj in mos.Get())
            //    //////{
            //    //////    String name = Convert.ToString("asdf " + nj[syntax]);

            //    //////return name;

            return name;
        }




        //private void button1_Click(object sender, EventArgs e) { GetComponent("Win32_Processor", "Name"); GetComponent("Win32_VideoController", "Name"); }
        //private void GetComponent(string hwclass, string syntax) { ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
        //    //foreach (ManagementObject mj in mos.Get()) { textBox1.AppendText((Convert.ToString(mj[syntax])) + "\r\n"); } }








        //public static GPUName()
        //{
        //    string name = Gr("Win32_VideoController", "Name");
        //    return name;
        //}
    }
}
