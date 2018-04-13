using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;


namespace SystemMonitoring.GUI
{
    public partial class FormDatenträger : Form
    {
        public List<string> Auswahldatenträger;

        public FormDatenträger(List<string> auswahldatenträger)
        {
            InitializeComponent();

            Auswahldatenträger = new List<string>();

            Auswahldatenträger = auswahldatenträger;

            //if (auswahldatenträger != null)
            //{

            //    /*for (int i = 0; i < auswahldatenträger.Count; i++)
            //    {
            //        Console.WriteLine("Länge des Übergebenen Arrays: " + auswahldatenträger[i].ToString());

            //    }*/

            //    //this.Auswahldatenträger = auswahldatenträger;

            //    ////}
            //    ////Console.WriteLine("Auswahldatenträger 1: " + Auswahldatenträger[0].ToString());

            //    ////public Datenträger_anzeigen(Auswahldatenträger)
            //    ////{
            //    //Die Abfrage funktioniert aufjedenfall, jetzt muss nur noch die ArrayList richtig übergeben werden
            //    for (int i = 0; i < auswahldatenträger.Count; i++)
            //{
            //    Console.WriteLine("Länge des Übergebenen Arrays: " + auswahldatenträger[i]);
            //    combox_Datenträger.Items.Add(auswahldatenträger[i].ToString());
            //}

            //combox_Datenträger.Items.Add(Auswahldatenträger[0]);

                //Gibt das erste Object der Liste in der ComboBox an --> noch erledigen gibt gleich die Werte für das erste Object an
                //combox_Datenträger.SelectedIndex = 0;
            
        }

        public void FormDatenträger_Load(object sender, EventArgs e)
        {
            Auswahldatenträger = new List<string>();
            Hardware.Datenträger.AlleDatenträger(Auswahldatenträger);

            
            
            Console.WriteLine("FormDatenträger_Load: " + Auswahldatenträger[1].ToString());

            //Die Abfrage funktioniert aufjedenfall, jetzt muss nur noch die ArrayList richtig übergeben werden
            for (int i = 0; i < Auswahldatenträger.Count; i++)
            {
                combox_Datenträger.Items.Add(Auswahldatenträger[i].ToString());
            }
            //Gibt das erste Object der Liste in der ComboBox an --> noch erledigen gibt gleich die Werte für das erste Object an
            //combox_Datenträger.SelectedIndex = 0;




            //ManagementObjectSearcher ds = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            //foreach (ManagementObject d in ds.Get())
            //{
            //    combox_Datenträger.Items.Add(d["Model"].ToString());
            //}
            //combox_Datenträger.SelectedIndex = 0;

        }

        private void combox_Datenträger_SelectionChanged(object sender, EventArgs e)
        {
            //ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
            //    "SELECT * FROM Win32_DiskDrive WHERE Model = '" + Hardware.Datenträger.Datenträgername + "'");

            //foreach (ManagementObject disk in mosDisks.Get())
            //{
            //    long Gesamtgroesse = long.Parse(disk["Size"].ToString());

            //    mlModel_Value.Text = disk["Model"].ToString();
            //    mlMediaType_Value.Text = disk["MediaType"].ToString();
            //    mlSerialNumber_Value.Text = disk["SerialNumber"].ToString();
            //    mlInterfaceType_Value.Text = disk["InterfaceType"].ToString();
            //    mlSize_Value.Text = string.Format("{0:0.00} GB", Gesamtgroesse / 1024 / 1024 / 1024);
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

            //mlModel_Value.Text = Hardware.Datenträger.Datenträgername;
            //}
        }

        //private void comboBoxDisks_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}