using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace SystemMonitoring.Hardware
{
    public class Memory
    {

        ManagementObjectSearcher memorysearcher;


        //PerformanceCounter freeMem = new PerformanceCounter("Memory", "Available MBytes");

        //double VerfügbarerSpeicher = Math.Round(Convert.ToDouble(((freeMem.NextValue() / 1024) )), 1);
        //double GesamterSpeicher = new ComputerInfo().TotalPhysicalMemory;
        //double totalMemory = Math.Round(Convert.ToDouble(((GesamterSpeicher / 1024 / 1024 / 1024))), 1);
        //double workMemory = totalMemory - VerfügbarerSpeicher;

        public Memory()
        {

            //Console.WriteLine("Arbeitsspeicher gesamt: " + totalMemory + " GB");
            //Console.WriteLine("Verfügbarer Arbeitsspeicher: " + VerfügbarerSpeicher + " GB");
            //Console.WriteLine("In Verwendung: " + workMemory + " GB");
        }


        public float GetFreeMemory()
        {
            PerformanceCounter freeMem = new PerformanceCounter("Memory", "Available Bytes");
            return freeMem.NextValue() / 1024;
        }

        public double GetTotalMemory()
        {
            double TotalPhysicalMemory = new ComputerInfo().TotalPhysicalMemory;
            double TotalMemory = Math.Round((TotalPhysicalMemory / 1024 / 1024 / 1024), 1);

            return TotalMemory;
        }

        public string GetMemoryType()
        {
            memorysearcher = new ManagementObjectSearcher("SELECT * FROM CIM_TemperatureSensor");

            try
            {
                foreach (ManagementObject queryObj in memorysearcher.Get())
                {
                    return queryObj["Description"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetPartNumber()
        {
            memorysearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            ManagementObjectCollection res = memorysearcher.Get();
            try
            {
                foreach (ManagementObject queryObj in memorysearcher.Get())
                {
                    return queryObj["PartNumber"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetManufacturer()
        {
            memorysearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            ManagementObjectCollection res = memorysearcher.Get();
            try
            {
                foreach (ManagementObject queryObj in memorysearcher.Get())
                {
                    return queryObj["Manufacturer"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetSerialNumber()
        {
            memorysearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            try
            {
                foreach (ManagementObject queryObj in memorysearcher.Get())
                {
                    return queryObj["SerialNumber"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}