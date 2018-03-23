﻿using System;
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

        //private void OnLoaded(object sender, EventArgs e)
        //{
        //    ManagementObjectSearcher ds = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

        //    foreach (ManagementObject d in ds.Get())
        //    {
        //        comboBoxDisks.Items.Add(d["Model"].ToString());
        //    }
        //    comboBoxDisks.SelectedIndex = 0;
        //}

        private void FormDatenträger_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher ds = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject d in ds.Get())
            {
                comboBoxDisks.Items.Add(d["Model"].ToString());
            }
            comboBoxDisks.SelectedIndex = 0;
        }

        private void comboBoxDisks_SelectionChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT * FROM Win32_DiskDrive WHERE Model = '" + comboBoxDisks.SelectedItem + "'");

            foreach (ManagementObject disk in mosDisks.Get())
            {
                long Gesamtgroesse = long.Parse(disk["Size"].ToString());

                mlModel_Value.Text = disk["Model"].ToString();
                mlMediaType_Value.Text = disk["MediaType"].ToString();
                mlSerialNumber_Value.Text = disk["SerialNumber"].ToString();
                mlInterfaceType_Value.Text = disk["InterfaceType"].ToString();
                mlSize_Value.Text = string.Format("{0:0.00} GB", Gesamtgroesse / 1024 / 1024 / 1024);
                mlPartitions_Value.Text = disk["Partitions"].ToString();
                mlSignature_Value.Text = disk["Signature"].ToString();
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
