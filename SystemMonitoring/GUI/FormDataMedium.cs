using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;


namespace SystemMonitoring.GUI
{
    public partial class FormDataMedium : Form
    {
        public FormDataMedium()
        {
            InitializeComponent();
        }
         
        public void FormDataMedium_Load(object sender, EventArgs e)
        {
            Combox_DataMedium.DataSource = Hardware.DataMedium.AllDataMediums();

            Console.WriteLine("Ausgewähltes Objekt: " + Combox_DataMedium.SelectedItem);
        }

        private void Combox_DataMedium_SelectionChanged(object sender, EventArgs e)
        {
            String CurrentDataMedium = Combox_DataMedium.SelectedItem.ToString();

            Hardware.DataMedium.DataMedium_Attributes(CurrentDataMedium);







            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT * FROM Win32_DiskDrive WHERE Model = '" + Combox_DataMedium.SelectedItem + "'");

            foreach (ManagementObject disk in mosDisks.Get())
            {
                //long Gesamtgroesse = long.Parse(disk["Size"].ToString());
                //mlModel_Value = disk["Model"].ToString();

                mlMediaType_Value.Text = disk["MediaType"].ToString();
                mlSerialNumber_Value.Text = disk["SerialNumber"].ToString();
                mlInterfaceType_Value.Text = disk["InterfaceType"].ToString();
                //mlSize_Value.Text = string.Format("{0:0.00} GB", Gesamtgroesse / 1024 / 1024 / 1024);
                mlPartitions_Value.Text = disk["Partitions"].ToString();
                //mlSignature_Value.Text = disk["Signature"].ToString();
                mlFirmware_Value.Text = disk["FirmwareRevision"].ToString();
                mlCylinders_Value.Text = disk["TotalCylinders"].ToString();
                mlSectors_Value.Text = disk["TotalSectors"].ToString();
                mlHeads_Value.Text = disk["TotalHeads"].ToString();
                mlTracks_Value.Text = disk["TotalTracks"].ToString();
                mlBytesPerSector_Value.Text = disk["BytesPerSector"].ToString();
                mlSectorsPerTrack_Value.Text = disk["SectorsPerTrack"].ToString();
                mlTracksPerCylinder_Value.Text = disk["TracksPerCylinder"].ToString();
            }
        }
    }
}