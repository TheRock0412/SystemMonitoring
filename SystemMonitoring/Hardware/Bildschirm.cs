using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.Hardware
{
    class Bildschirm
    {        
        public Bildschirm()
        {

        }

        public static List<string> AlleMonitore()
        {
            List<string> Auswahlmonitor = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");

            foreach (ManagementObject d in mos.Get())
            {
                Auswahlmonitor.Add(d["Caption"].ToString());
            }
            return Auswahlmonitor;


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
        }


       

        public static string BildschirmName(string name, string syntax)
        {
            String bildName = string.Empty;

            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + name);
            foreach (ManagementObject nj in mos.Get())
            {
                if (bildName == String.Empty)
                {
                    bildName = Convert.ToString(nj[syntax]);
                }
                else
                {
                    MessageBox.Show("Bildschirmbezeichnung nicht gefunden!");
                }
            }
            return bildName;
        }

        public static string BildschirmTyp(string name, string syntax)
        {
            String bildTyp = string.Empty;

            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + name);
            foreach (ManagementObject nj in mos.Get())
            {
                if (bildTyp == String.Empty)
                {
                    bildTyp = Convert.ToString(nj[syntax]);
                }
                else
                {
                    MessageBox.Show("Bildschirmbezeichnung nicht gefunden!");
                }
            }
            return bildTyp;
        }
    }
}
