using System;
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

            mlManufacturer_Value.Text = monitor.GetMonitorManufacturer(CurrentMonitor);
            mlMonitorType_Value.Text = monitor.GetMonitorType(CurrentMonitor);
            //mlDisplayFormat_Value.Text = monitor.GetPixelsPerXLogicalInch(CurrentMonitor);
            mlStatus_Value.Text = monitor.GetStatus(CurrentMonitor);
            mlPNPDevice_Value.Text = monitor.GetPNPDeviceID(CurrentMonitor);
            mlDevice_Value.Text = monitor.GetDeviceID(CurrentMonitor);
            //metroLabel15.Text = monitor.GetBandwidth(CurrentMonitor);

        }
    }
}