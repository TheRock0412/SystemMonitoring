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
    public partial class FormBildschirm : Form
    {
        string BildName;
        string Caption;
        string Description;
        string DeviceID;
        string MonitorType;
        string CreationClassName;

        public FormBildschirm()
        {
            InitializeComponent();

            ManagementObjectSearcher OS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");
            //ManagementObjectCollection queryCollection = OS.Get();
            foreach (ManagementObject mo in OS.Get())
            {
                BildName = mo["Name"].ToString();
                //Caption = mo["MonitorManufacturer"].ToString();
                //Description = mo["PNPDeviceID"].ToString();
                //DeviceID = mo["Status"].ToString();
                //MonitorType = mo["DeviceID"].ToString();
                //CreationClassName = mo["Bandwidth"].ToString();
                Console.WriteLine(CreationClassName);
            }

            //metroLabel2.Text = BildName;
            metroLabel4.Text = Caption;
            metroLabel6.Text = Description;
            metroLabel8.Text = DeviceID;
            metroLabel10.Text = MonitorType;
            //metroLabel12.Text = CreationClassName;
        }

        private void FormBildschirm_Load(object sender, EventArgs e)
        {
            combo_Monitor.DataSource = Hardware.Bildschirm.AlleMonitore();
        }
    }
}