using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.GUI
{
    public partial class FormBildschirm : Form
    {
        public FormBildschirm()
        {
            InitializeComponent();

            metroLabel2.Text = Hardware.Bildschirm.BildschirmName("Win32_DesktopMonitor", "Name");
            metroLabel4.Text = Hardware.Bildschirm.BildschirmTyp("Win32_DesktopMonitor", "MonitorManufacturer");
            metroLabel6.Text = Hardware.Bildschirm.BildschirmTyp("Win32_DesktopMonitor", "PNPDeviceID");
            metroLabel8.Text = Hardware.Bildschirm.BildschirmTyp("Win32_DesktopMonitor", "DeviceID");
            metroLabel10.Text = Hardware.Bildschirm.BildschirmTyp("Win32_DesktopMonitor", "Status");
            //metroLabel4.Text = Hardware.Bildschirm.BildschirmTyp("Win32_DesktopMonitor", "Status");
        }
    }
}
