using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormSoftware : Form
    {
        string OS_Name;
        string Version;
        string Hersteller;

        public FormSoftware()
        {
            InitializeComponent();

            ManagementObjectSearcher OS = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection queryCollection1 = OS.Get();
            foreach (ManagementObject mo in queryCollection1)
            {
                //OS_Name = mo["csname"].ToString();
                OS_Name = mo["OSArchitecture"].ToString();
                Version = mo["version"].ToString();
                Hersteller = mo["Manufacturer"].ToString();
            }
        }
    }
}
