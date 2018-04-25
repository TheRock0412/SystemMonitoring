using System;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace SystemMonitoring.Hardware
{
    public class Memory
    {

        ManagementObjectSearcher memorysearcher;

        public Memory()
        {

        }







        public int GetFreeMemory()
        {
            ObjectQuery winQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
            int test = 0;
            foreach (ManagementObject item in searcher.Get())
            {
                //Console.WriteLine("Total Space = " + item["TotalPageFileSpace"]);
                test = Convert.ToInt32(item["FreePhysicalMemory"]);

                //Console.WriteLine("Total Virtual Memory = " + item["TotalVirtualMemory"]);
                //Console.WriteLine("Available Virtual Memory = " + item["AvailableVirtualMemory"]);
            }
            return test / 1024;
        }


        //var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

        //var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
        //{
        //    FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
        //    TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
        //}).FirstOrDefault();

        //if (memoryValues != null)
        //{
        //    var percent = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;
        //}




        //}

        public double GetTotalMemory()
        {
            double TotalPhysicalMemory = new ComputerInfo().TotalPhysicalMemory;
            double TotalMemory = Math.Round((TotalPhysicalMemory / 1024 / 1024 / 1024), 1);

            return TotalMemory;
        }

        //public string GetMemoryType()
        //{
        //    memorysearcher = new ManagementObjectSearcher("SELECT * FROM CIM_TemperatureSensor");

        //    try
        //    {
        //        foreach (ManagementObject queryObj in memorysearcher.Get())
        //        {
        //            return queryObj["Description"].ToString();
        //        }
        //        return "";
        //    }
        //    catch (Exception e)
        //    {
        //        return "";
        //    }
        //}

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