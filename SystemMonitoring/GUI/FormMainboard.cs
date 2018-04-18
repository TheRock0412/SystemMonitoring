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

            mlMainboradname_Value.Text = Hardware.Mainboard.Product;

            mlSerialNumber_Value.Text = Hardware.Mainboard.SerialNumber;
            mlVersion_Value.Text = Hardware.Mainboard.Version;
            //mlInstallDate_Value.Text = Hardware.Mainboard.InstallDate;
            mlManufacture_Value.Text = Hardware.Mainboard.Manufacturer;
            mlPrimaryBusType_Value.Text = Hardware.Mainboard.PrimaryBusType;
            mlSecondaryBusType_Value.Text = Hardware.Mainboard.SecondaryBusType;
            mlStatus_Value.Text = Hardware.Mainboard.Status;
            //mlRevisionsnumber_Value.Text = Hardware.Mainboard.RevisionNumber;
            //mlPartnumber_Value.Text = Hardware.Mainboard.PartNumber;            
            //mlModel_Value.Text = Hardware.Mainboard.Model;
        }
    }
}
