using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;


namespace SystemMonitoring.GUI
{
    public partial class FormDatenträger : Form
    {

        public FormDatenträger()
        {
            InitializeComponent();
        }
         
        public void FormDatenträger_Load(object sender, EventArgs e)
        {
            combox_Datenträger.DataSource = Hardware.Datenträger.AlleDatenträger();

            //Console.WriteLine("Ausgewähltes Objekt: " + combox_Datenträger.SelectedItem);
            String AktuellerDatenträger = combox_Datenträger.SelectedItem.ToString();

            Hardware.Datenträger.Datenträger_Eigenschaften(AktuellerDatenträger);
        }

        private void combox_Datenträger_SelectionChanged(object sender, EventArgs e)
        {
            String AktuellerDatenträger = combox_Datenträger.SelectedItem.ToString();

            Hardware.Datenträger.Datenträger_Eigenschaften(AktuellerDatenträger);

            //Console.WriteLine("Ausgewähltes Objekt: " + sender + "Was steht in e? " + e);

            //ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
            //    "SELECT * FROM Win32_DiskDrive WHERE Model = '" + combox_Datenträger.SelectedItem + "'");

            //foreach (ManagementObject disk in mosDisks.Get())
            //{
            //    //long Gesamtgroesse = long.Parse(disk["Size"].ToString());
            //    //mlModel_Value = disk["Model"].ToString();

            //    mlMediaType_Value.Text = disk["MediaType"].ToString();
            //    mlSerialNumber_Value.Text = disk["SerialNumber"].ToString();
            //    mlInterfaceType_Value.Text = disk["InterfaceType"].ToString();
            //    //mlSize_Value.Text = string.Format("{0:0.00} GB", Gesamtgroesse / 1024 / 1024 / 1024);
            //    mlPartitions_Value.Text = disk["Partitions"].ToString();
            //    mlSignature_Value.Text = disk["Signature"].ToString();
            //    mlFirmware_Value.Text = disk["FirmwareRevision"].ToString();
            //    mlCylinders_Value.Text = disk["TotalCylinders"].ToString();
            //    mlSectors_Value.Text = disk["TotalSectors"].ToString();
            //    mlHeads_Value.Text = disk["TotalHeads"].ToString();
            //    mlTracks_Value.Text = disk["TotalTracks"].ToString();
            //    mlBytesPerSector_Value.Text = disk["BytesPerSector"].ToString();
            //    mlSectorsPerTrack_Value.Text = disk["SectorsPerTrack"].ToString();
            //    mlTracksPerCylinder_Value.Text = disk["TracksPerCylinder"].ToString();
            //}
        }
    }
}