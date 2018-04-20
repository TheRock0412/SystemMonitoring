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
    public partial class FormMonitor : Form
    {
        Hardware.Monitor monitor;
        public string CurrentMonitor;

        public FormMonitor()
        {
            InitializeComponent();

            //ManagementObjectSearcher OS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");
            //ManagementObjectCollection queryCollection = OS.Get();

            //Console.WriteLine("asdfasfd: " + queryCollection);

            //foreach (ManagementObject mo in OS.Get())
            //{
            //    //BildName = mo["Name"].ToString();
            //    //Caption = mo["MonitorManufacturer"].ToString();
            //    //Description = mo["PNPDeviceID"].ToString();
            //    //DeviceID = mo["Status"].ToString();
            //    //MonitorType = mo["DeviceID"].ToString();
            //    //CreationClassName = mo["Bandwidth"].ToString();
            //}
            

            ////metroLabel2.Text = BildName;

            //metroLabel6.Text = Description;
            //metroLabel8.Text = DeviceID;
            //metroLabel10.Text = MonitorType;
            ////metroLabel12.Text = CreationClassName;
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            monitor = new Hardware.Monitor();
            Combox_Monitor.DataSource = monitor.AllMonitors();
        }

        private void Combox_Monitor_SelectionChanged(object sender, EventArgs e)
        {
            CurrentMonitor = Combox_Monitor.SelectedItem.ToString();

            metroLabel4.Text = monitor.GetStatus(CurrentMonitor);
            metroLabel6.Text = monitor.GetMonitorManufacturer(CurrentMonitor);
            //metroLabel8.Text = monitor.GetPixelsPerXLogicalInch(CurrentMonitor);
            metroLabel10.Text = monitor.GetMonitorType(CurrentMonitor);
            metroLabel12.Text = monitor.GetPNPDeviceID(CurrentMonitor);
            metroLabel1.Text = monitor.GetDeviceID(CurrentMonitor);
            //metroLabel15.Text = monitor.GetBandwidth(CurrentMonitor);

        }
    }
}