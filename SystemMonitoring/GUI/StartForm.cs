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
        string DataMediums;
        string Monitors;

        public StartForm()
        {
            InitializeComponent();

            Hardware.Memory memory = new Hardware.Memory();
            Hardware.CPU cpu = new Hardware.CPU();
            Hardware.DataMedium datamedium = new Hardware.DataMedium();
            Hardware.Graphics graphics = new Hardware.Graphics();
            Hardware.Internet internet = new Hardware.Internet();
            Hardware.Mainboard mainboard = new Hardware.Mainboard();
            Hardware.Monitor monitor = new Hardware.Monitor();

            mlComputerName_Value.Text = System.Windows.Forms.SystemInformation.ComputerName.ToString();
            mlUserName_Value.Text = Environment.UserName;
            mlMemory_Value.Text = "Name";//memory.MemoryName;
            mlCPU_Value.Text = cpu.CPUName();

            foreach (string display in monitor.AllMonitors())
            {
                Monitors += display.ToString() + "\n";
            }

            mlMonitor_Value.Text = Monitors;
            //mlGraphics_Value.Text = graphics.GPUName("Win32_VideoController", "Name");
            mlInternet_Value.Text = internet.GetNetworkAdapter();
            mlMainboard_Value.Text = mainboard.GetProduct();

            foreach (string medium in datamedium.AllDataMediums())
            {
                DataMediums += medium.ToString() + "\n";
            }
            mlDataMedium_Value.Text = DataMediums; //Hardware.Bildschirm.BildschirmName("MSFT_MTLogicalProcessor", "Description");            
        }
    }
}