using System;
using System.Management;
using System.Management.Instrumentation;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SystemMonitoring
{
    static class Program
    {
        static void Main()
        {

            //Bezeichnung für die Variablen
            //ml = metroLabel


            //Link für die WIM Bib: msdn.microsoft.com/en-us/library/aa389273.aspx




            //Hardware.Grafikkarte.Gr("Win32_VideoController", "Name");

            //Hardware.SystemInfos systemInfos = new Hardware.SystemInfos();
            //Hardware.CPU cpuInfos = new Hardware.CPU();
            //Hardware.RAM ramInfos = new Hardware.RAM();

            //systemInfos.GetType();
            //ramInfos.GetType();

            //Console.WriteLine("Motherboard Properties:");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //Console.WriteLine("-----------------------------------------------------------------------------");
            //Console.WriteLine("Availability: " + Hardware.Mainboard.Availability);
            //Console.WriteLine("HostingBoard: " + Hardware.Mainboard.HostingBoard);
            //Console.WriteLine("InstallDate: " + Hardware.Mainboard.InstallDate);
            //Console.WriteLine("Manufacturer: " + Hardware.Mainboard.Manufacturer);
            //Console.WriteLine("Model: " + Hardware.Mainboard.Model);
            //Console.WriteLine("PartNumber: " + Hardware.Mainboard.PartNumber);
            //Console.WriteLine("PNPDeviceID: " + Hardware.Mainboard.PNPDeviceID);
            //Console.WriteLine("PrimaryBusType: " + Hardware.Mainboard.PrimaryBusType);
            //Console.WriteLine("Product: " + Hardware.Mainboard.Product);
            //Console.WriteLine("Removable: " + Hardware.Mainboard.Removable);
            //Console.WriteLine("Replaceable: " + Hardware.Mainboard.Replaceable);
            //Console.WriteLine("RevisionNumber: " + Hardware.Mainboard.RevisionNumber);
            //Console.WriteLine("SecondaryBusType: " + Hardware.Mainboard.SecondaryBusType);
            //Console.WriteLine("SerialNumber: " + Hardware.Mainboard.SerialNumber);
            //Console.WriteLine("Status: " + Hardware.Mainboard.Status);
            //Console.WriteLine("SystemName: " + Hardware.Mainboard.SystemName);
            //Console.WriteLine("Version: " + Hardware.Mainboard.Version);
            //Console.ReadLine();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
