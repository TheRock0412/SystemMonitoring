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

            metroLabel4.Text = Hardware.Mainboard.Product;
            metroLabel6.Text = Hardware.CPU.CPUName;
            metroLabel8.Text = Hardware.RAM.RAMName;
            metroLabel10.Text = Hardware.Grafikkarte.GPUName("Win32_VideoController", "Name");
           // metroLabel12.Text = Hardware.Bildschirm.BildschirmName("MSFT_MTLogicalProcessor", "Description");
            metroLabel14.Text = Hardware.Internet.GetNetworkAdapter();
            metroLabel16.Text = Hardware.Grafikkarte.test;
            //metroLabel18.Text = Hardware.Internet.GetGateway();
        }
    }
}