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

            Hardware.Mainboard mainboard = new Hardware.Mainboard();
            
            mlMainboradname_Value.Text = mainboard.GetProduct();
            
            mlSerialNumber_Value.Text = mainboard.GetSerialNumber();
            mlVersion_Value.Text = mainboard.GetVersion();
            //mlInstallDate_Value.Text = mainboard.GetInstallDate();
            mlManufacture_Value.Text = mainboard.GetManufacturer();
            mlPrimaryBusType_Value.Text = mainboard.GetPrimaryBusType();
            mlSecondaryBusType_Value.Text = mainboard.GetSecondaryBusType();
            mlStatus_Value.Text = mainboard.GetStatus();
            //mlRevisionsnumber_Value.Text = mainboard.GetRevisionNumber();
            //mlPartnumber_Value.Text = mainboard.GetPartNumber();            
            //mlModel_Value.Text = mainboard.GetModel();
        }
    }
}
