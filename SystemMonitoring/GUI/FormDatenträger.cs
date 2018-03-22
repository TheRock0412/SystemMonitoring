using System;
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
                Console.WriteLine("Test: " + comboBoxDisks.Items.Add(d["Model"].ToString()));
            }
            comboBoxDisks.SelectedIndex = 0;
        }

        private void comboBoxDisks_SelectionChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT * FROM Win32_DiskDrive WHERE Model = '" + comboBoxDisks.SelectedItem + "'");

            foreach (ManagementObject disk in mosDisks.Get())
            {
                mlMediaType_Value.Text = disk["MediaType"].ToString();
                metroLabel6.Text = disk["Model"].ToString();
                metroLabel8.Text = disk["SerialNumber"].ToString();
                metroLabel10.Text = disk["InterfaceType"].ToString();
                metroLabel12.Text = disk["Size"].ToString() + " bytes";
                metroLabel14.Text = disk["Partitions"].ToString();
                //tbSignature.Text = disk["Signature"].ToString();
                //tbFirmware.Text = disk["FirmwareRevision"].ToString();
                //tbCylinders.Text = disk["TotalCylinders"].ToString();
                //tbSectors.Text = disk["TotalSectors"].ToString();
                //tbHeads.Text = disk["TotalHeads"].ToString();
                //tbTracks.Text = disk["TotalTracks"].ToString();
                //tbBytesPerSector.Text = disk["BytesPerSector"].ToString();
                //tbSectorsPerTrack.Text = disk["SectorsPerTrack"].ToString();
                //tbTracksPerCylinder.Text = disk["TracksPerCylinder"].ToString();
            }
        }
    }
}
