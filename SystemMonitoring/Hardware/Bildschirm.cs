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
