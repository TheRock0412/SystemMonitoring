using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class StartForm : Form
    {
        string OS_Name;
        string Version;
        string Hersteller;

        public StartForm()
        {
            InitializeComponent();

            ManagementObjectSearcher OS = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection queryCollection1 = OS.Get();
            foreach (ManagementObject mo in queryCollection1)
            {
                OS_Name = mo["name"].ToString();
                Version = mo["version"].ToString();
                Hersteller = mo["Manufacturer"].ToString();
            }

            metroLabel2.Text = System.Windows.Forms.SystemInformation.ComputerName.ToString();
            metroLabel26.Text = Environment.UserName;
            metroLabel4.Text = Hardware.Mainboard.Product;
            metroLabel6.Text = Hardware.CPU.CPUName;
            metroLabel8.Text = Hardware.RAM.RAMName;
            metroLabel10.Text = Hardware.Grafikkarte.GPUName("Win32_VideoController", "Name");
            metroLabel12.Text = Hardware.Datenträger.DatenträgerName;
            metroLabel14.Text = Hardware.Internet.GetNetworkAdapter();
            metroLabel16.Text = Hardware.Internet.GetIPAddress4();
            metroLabel18.Text = Hardware.Internet.GetGateway();
            metroLabel20.Text = OS_Name;
            metroLabel22.Text = Hersteller;
            metroLabel24.Text = Version;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}