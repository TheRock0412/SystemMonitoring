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
        string gehtdas;
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

            metroLabel2.Text = System.Windows.Forms.SystemInformation.ComputerName.ToString();
            metroLabel26.Text = Environment.UserName;

            mlMemory_Value.Text = "Name";//Hardware.RAM.RAMName;
            mlCPU_Value.Text = Hardware.CPU.CPUName;
            
            for(int i = 0; i < datamedium.AllDataMediums().Count; i++)
            {
                gehtdas = String.Join(", ",datamedium.AllDataMediums()[i].ToArray());
                Console.WriteLine("Foreach: " + gehtdas);
                //Console.WriteLine("Foreach: " + datamedium.AllDataMediums()[i]);
            }

            mlDataMedium_Value.Text = gehtdas; 
            mlGraphics_Value.Text = Hardware.Graphics.GPUName("Win32_VideoController", "Name");
            mlInternet_Value.Text = Hardware.Internet.GetNetworkAdapter();
            mlMainboard_Value.Text = mainboard.GetProduct();
            mlMonitor_Value.Text = "Name"; //Hardware.Bildschirm.BildschirmName("MSFT_MTLogicalProcessor", "Description");            
        }
    }
}