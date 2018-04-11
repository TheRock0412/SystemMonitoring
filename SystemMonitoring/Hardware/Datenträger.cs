using System;
using System.Collections;
using System.Management;
using System.Windows.Forms;
using SystemMonitoring.GUI;

namespace SystemMonitoring.Hardware
{
    class Datenträger
    {
        public ArrayList Auswahldatenträger { get; private set; }
        // public static string Datenträgername;

        public static ManagementObjectSearcher mos;

        public Datenträger()
        {
            ArrayList Auswahldatenträger = new ArrayList(); // = new ArrayList();
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject d in mos.Get())
            {
                Auswahldatenträger.Add(d["Model"].ToString());
            }
            FormDatenträger datenträger = new FormDatenträger(Auswahldatenträger);
        }

        public void AlleDatenträger()
        {
            //ArrayList Auswahldatenträger = new ArrayList(); // = new ArrayList();
            //mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            //foreach (ManagementObject d in mos.Get())
            //{
            //    Auswahldatenträger.Add(d["Model"].ToString());
            //}
            //FormDatenträger datenträger = new FormDatenträger(Auswahldatenträger);
        }

        //private void comboBoxDisks_SelectionChanged(object sender, EventArgs e)
        //{
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + comboBoxDisks.SelectedItem + "'");

        //    foreach (ManagementObject disk in mosDisks.Get())
        //    {
        //        long Gesamtgroesse = long.Parse(disk["Size"].ToString());
        //        Datenträgername = disk["Model"].ToString();

        //        //mlMediaType_Value.Text = disk["MediaType"].ToString();
        //        //mlSerialNumber_Value.Text = disk["SerialNumber"].ToString();
        //        //mlInterfaceType_Value.Text = disk["InterfaceType"].ToString();
        //        //mlSize_Value.Text = string.Format("{0:0.00} GB", Gesamtgroesse / 1024 / 1024 / 1024);
        //        //mlPartitions_Value.Text = disk["Partitions"].ToString();
        //        //mlSignature_Value.Text = disk["Signature"].ToString();
        //        //mlFirmware_Value.Text = disk["FirmwareRevision"].ToString();
        //        //mlCylinders_Value.Text = disk["TotalCylinders"].ToString();
        //        //mlSectors_Value.Text = disk["TotalSectors"].ToString();
        //        //mlHeads_Value.Text = disk["TotalHeads"].ToString();
        //        //mlTracks_Value.Text = disk["TotalTracks"].ToString();
        //        //mlBytesPerSector_Value.Text = disk["BytesPerSector"].ToString();
        //        //mlSectorsPerTrack_Value.Text = disk["SectorsPerTrack"].ToString();
        //        //mlTracksPerCylinder_Value.Text = disk["TracksPerCylinder"].ToString();
        //    }
        //}
    }
}
