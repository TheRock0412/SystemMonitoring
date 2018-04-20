using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;


namespace SystemMonitoring.GUI
{
    public partial class FormDataMedium : Form
    {
        Hardware.DataMedium datamedium;
        private string CurrentDataMedium;

        public FormDataMedium()
        {
            InitializeComponent();
        }

        public void FormDataMedium_Load(object sender, EventArgs e)
        {
            datamedium = new Hardware.DataMedium();
            Combox_DataMedium.DataSource = datamedium.AllDataMediums();
        }

        private void Combox_DataMedium_SelectionChanged(object sender, EventArgs e)
        {
            CurrentDataMedium = Combox_DataMedium.SelectedItem.ToString();

            mlModel_Value.Text = datamedium.GetModel(CurrentDataMedium);
            mlMediaType_Value.Text = datamedium.GetMediaType(CurrentDataMedium);
            mlSerialNumber_Value.Text = datamedium.GetSerialNumber(CurrentDataMedium);
            mlInterfaceType_Value.Text = datamedium.GetInterfaceType(CurrentDataMedium);
            mlSize_Value.Text = datamedium.GetSize(CurrentDataMedium);
            mlPartitions_Value.Text = datamedium.GetPartitions(CurrentDataMedium);
            //mlSignature_Value.Text = datamedium.GetSignature(CurrentDataMedium);
            mlFirmware_Value.Text = datamedium.GetFirmwareRevision(CurrentDataMedium);
            mlCylinders_Value.Text = datamedium.GetTotalCylinders(CurrentDataMedium);
            mlSectors_Value.Text = datamedium.GetTotalSectors(CurrentDataMedium);
            mlHeads_Value.Text = datamedium.GetTotalHeads(CurrentDataMedium);
            mlTracks_Value.Text = datamedium.GetTotalTracks(CurrentDataMedium);
            mlBytesPerSector_Value.Text = datamedium.GetBytesPerSector(CurrentDataMedium);
            mlSectorsPerTrack_Value.Text = datamedium.GetSectorsPerTrack(CurrentDataMedium);
            mlTracksPerCylinder_Value.Text = datamedium.GetTracksPerCylinder(CurrentDataMedium);
        }
    }
}