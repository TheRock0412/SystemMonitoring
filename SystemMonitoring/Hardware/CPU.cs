using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace SystemMonitoring.Hardware
{
    class CPU
    {



        public CPU()
        {



            //Object cpuSpeed = RegKey.GetValue("~MHz");
            //Object cpuType = RegKey.GetValue("VendorIdentifier");

            //Console.WriteLine("You have a {0} running at {1} MHz.", cpuType, cpuSpeed);

        }

        public string CPUName()
        {
            RegistryKey RegKey = Registry.LocalMachine;
            RegKey = RegKey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");

            try
            {
                return RegKey.GetValue("ProcessorNameString").ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public int CPUSpeed()
        {
            //ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            //uint sp = (uint)(Mo["CurrentClockSpeed"]);
            //Mo.Dispose();
            //return sp;

            //https://mycsharp.de/wbb2/thread.php?postid=3745118
            //https://dotnet-snippets.de/snippet/systeminformationen-aus-der-registry-lesen/1750
            //https://dotnet-snippets.de/snippet/cpu-geschwindigkeit-ermitteln/99


            //try
            //{
            //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            //    foreach (ManagementObject queryObj in searcher.Get())
            //    {
            //        Console.WriteLine("-----------------------------------");
            //        Console.WriteLine("MSAcpi_ThermalZoneTemperature instance");
            //        Console.WriteLine("-----------------------------------");
            //        Console.WriteLine("CurrentTemperature: {0}", queryObj["CurrentTemperature"]);
            //    }
            //    return "";
            //}
            //catch (ManagementException e)
            //{
            //    MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            //}
        //    return 0;
        //}

        //public int CPUTest()
        //{
            ManagementObjectSearcher managementObject = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            int Speed;

                foreach (ManagementObject queryObj in managementObject.Get())
                {
                    Speed = Convert.ToInt32(queryObj["CurrentClockSpeed"]);
                    Console.WriteLine("Speed: " + Speed);
                    return Speed;
                }

            //do
            //{

            //Thread.Sleep(1000);

               return 0;
            //}
            //while (Speed != null);
            //{
            //    return 0;
            //}
        }

        //static public string CPUType
        //{
        //    get
        //    {
        //        try
        //        {
        //            return RegKey.GetValue("VendorIdentifier").ToString();
        //        }
        //        catch (Exception e)
        //        {
        //            return "";
        //        }
        //    }
        //}

    }
}
