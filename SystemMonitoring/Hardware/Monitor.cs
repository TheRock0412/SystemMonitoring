using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.Hardware
{
    class Monitor
    {
        public string CurrentMonitor;

        public Monitor()
        {

        }

        public List<string> AllMonitors()
        {
            List<string> Selectionmonitor = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");

            foreach (ManagementObject d in mos.Get())
            {
                Selectionmonitor.Add(d["Caption"].ToString());
            }
            return Selectionmonitor;
        }

        public void Monitor_Attributes(string SelectedMonitor)
        {
            Console.WriteLine("Übergabe der Auswahl 5: " + SelectedMonitor);
            CurrentMonitor = SelectedMonitor;
            Console.WriteLine("Current Monitor 1: " + CurrentMonitor);
        }

        public string GetSyntax()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM CIM_DesktopMonitor WHERE Caption = '" + CurrentMonitor);
            Console.WriteLine("Current Monitor 2: " + CurrentMonitor);

            try
            {
                foreach (ManagementObject queryObj in mos.Get())
                {
                    return queryObj["Name"].ToString();
                    Console.WriteLine("Cu");
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        //public static string BildschirmTyp(string name, string syntax)
        //{
        //    String bildTyp = string.Empty;

        //    ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + name);
        //    foreach (ManagementObject nj in mos.Get())
        //    {
        //        if (bildTyp == String.Empty)
        //        {
        //            bildTyp = Convert.ToString(nj[syntax]);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Bildschirmbezeichnung nicht gefunden!");
        //        }
        //    }
        //    return bildTyp;
        //}
    }
}
            //ManagementObjectSearcher OS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");
            ////ManagementObjectCollection queryCollection = OS.Get();
            //foreach (ManagementObject mo in OS.Get())
            //{
            //    BildName = mo["Name"].ToString();
            //    //Caption = mo["MonitorManufacturer"].ToString();
            //    //Description = mo["PNPDeviceID"].ToString();
            //    //DeviceID = mo["Status"].ToString();
            //    //MonitorType = mo["DeviceID"].ToString();
            //    //CreationClassName = mo["Bandwidth"].ToString();
            //    Console.WriteLine(CreationClassName);
            //}
