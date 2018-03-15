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
    public partial class FormEthernet : Form
    {
        public FormEthernet()
        {
            InitializeComponent();

            metroLabel2.Text = Hardware.Ethernet.GetNetworkAdapter();
            metroLabel4.Text = Hardware.Ethernet.GetNetworkName();
            metroLabel6.Text = Hardware.Ethernet.GetDNSName();
            metroLabel8.Text = Hardware.Ethernet.GetIPAddress4();
            metroLabel10.Text = Hardware.Ethernet.GetIPAddress6();
            metroLabel12.Text = Hardware.Ethernet.GetMACAddress();

        }
    }
}
