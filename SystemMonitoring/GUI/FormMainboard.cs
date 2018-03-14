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
    public partial class FormMainboard : Form
    {

        public FormMainboard()
        {
            InitializeComponent();

            metroLabel2.Text = Hardware.Mainboard.Product;
            metroLabel4.Text = Hardware.Mainboard.SerialNumber;
            metroLabel6.Text = Hardware.Mainboard.Manufacturer;
            metroLabel8.Text = Hardware.Mainboard.PrimaryBusType;
            metroLabel10.Text = Hardware.Mainboard.SecondaryBusType;
            metroLabel12.Text = Hardware.Mainboard.Version;
        }
    }
}
