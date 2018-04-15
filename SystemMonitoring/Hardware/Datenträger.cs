using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;
using SystemMonitoring.GUI;

namespace SystemMonitoring.Hardware
{
    class Datenträger
    {
        public Datenträger()
        {
            //mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            //Auswahldatenträger = new List<string>();

            //foreach (ManagementObject d in mos.Get())
            //{
            //    Auswahldatenträger.Add(d["Model"].ToString());
            //}

            //for (int i = 0; i < Auswahldatenträger.Count; i++)
            //{
            //    //Console.WriteLine("Was steht alles im in der Liste: " + Auswahldatenträger[i].ToString());
            //}
            //FormDatenträger datenträger = new FormDatenträger(Auswahldatenträger);
        }

        public static List<string> AlleDatenträger()
        {
            List<string> Auswahldatenträger = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject d in mos.Get())
            {
                Auswahldatenträger.Add(d["Model"].ToString());
            }
           return Auswahldatenträger;
        }

        public static void Datenträger_Eigenschaften(String Ausgewählter_Datenträger)
        {
            List<string> Liste_der_Datenträger_Eigenschaften = new List<string>();

            Console.WriteLine("Übergabe der Auswahl 5: " + Ausgewählter_Datenträger);

            //ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + Ausgewählter_Datenträger);

            //foreach (ManagementObject disk in mos.Get())
            //{
            //    Liste_der_Datenträger_Eigenschaften.Add(disk["MediaType"].ToString());
            //}
            //Console.WriteLine("Liste der Eigenschaften: " + Liste_der_Datenträger_Eigenschaften);
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
