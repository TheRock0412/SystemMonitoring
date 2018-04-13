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
        public StartForm()
        {
            InitializeComponent();

            metroLabel2.Text = System.Windows.Forms.SystemInformation.ComputerName.ToString();
            metroLabel26.Text = Environment.UserName;

            mlArbeitsspeichername_Value.Text = "Name";//Hardware.RAM.RAMName;
            mlMonitor_Value.Text = "Name"; //Hardware.Bildschirm.BildschirmName("MSFT_MTLogicalProcessor", "Description");
            mlCPU_Value.Text = Hardware.CPU.CPUName;
            mlDatenräger_Value.Text = "Name";
            mlGrafikkarte_Value.Text = Hardware.Grafikkarte.GPUName("Win32_VideoController", "Name");
            mlInternet_Value.Text = Hardware.Internet.GetNetworkAdapter();
            mlMainboard_Value.Text = Hardware.Mainboard.Product;
        }
    }
}