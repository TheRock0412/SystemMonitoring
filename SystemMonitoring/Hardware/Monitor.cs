using System;
using System.Collections.Generic;
using System.Management;

namespace SystemMonitoring.Hardware
{
    class Monitor
    {
        private ManagementObjectSearcher monitorSearcher;

        public Monitor()
        {

        }

        public List<string> AllMonitors()
        {
            List<string> Selectionmonitor = new List<string>();
            monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");

            foreach (ManagementObject d in monitorSearcher.Get())
            {
                Selectionmonitor.Add(d["Name"].ToString());
            }
            return Selectionmonitor;
        }

        public string GetStatus(string SelectedMonitor)
        {
            monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

            try
            {
                foreach (ManagementObject queryObj in monitorSearcher.Get())
                {
                    return queryObj["Status"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetMonitorManufacturer(string SelectedMonitor)
        {
            monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

            try
            {
                foreach (ManagementObject queryObj in monitorSearcher.Get())
                {
                    return queryObj["MonitorManufacturer"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        ////public string GetPixelsPerXLogicalInch(string SelectedMonitor)
        ////{
        ////    monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

        ////    try
        ////    {
        ////        foreach (ManagementObject queryObj in monitorSearcher.Get())
        ////        {
        ////            return queryObj["Bandwidth"].ToString();
        ////        }
        ////        return "";
        ////    }
        ////    catch (Exception e)
        ////    {
        ////        return "";
        ////    }
        ////}

        public string GetMonitorType(string SelectedMonitor)
        {
            monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

            try
            {
                foreach (ManagementObject queryObj in monitorSearcher.Get())
                {
                    return queryObj["MonitorType"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetPNPDeviceID(string SelectedMonitor)
        {
            monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

            try
            {
                foreach (ManagementObject queryObj in monitorSearcher.Get())
                {
                    return queryObj["PNPDeviceID"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetDeviceID(string SelectedMonitor)
        {
            monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

            try
            {
                foreach (ManagementObject queryObj in monitorSearcher.Get())
                {
                    return queryObj["DeviceID"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        //public string GetBandwidth(string SelectedMonitor)
        //{
        //    monitorSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor WHERE Name = '" + SelectedMonitor + "'");

        //    try
        //    {
        //        foreach (ManagementObject queryObj in monitorSearcher.Get())
        //        {
        //            return queryObj["Bandwidth"].ToString();
        //        }
        //        return "";
        //    }
        //    catch (Exception e)
        //    {
        //        return "";
        //    }
        //}
    }
}
            //ManagementObjectSearcher OS = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM CIM_DesktopMonitor");
            ////ManagementObjectCollection queryCollection = OS.Get();
            //foreach (ManagementObject mo in OS.Get())
            //{
            //    BildName = mo["Name"].ToString();
            //    //Caption = mo["MonitorManufacturer"].ToString();
            //    //Description = mo["PNPDeviceID"].ToString();
            //    //DeviceID = mo["Status"].ToString();
            //    //MonitorType = mo["DeviceID"].ToString();
            //    //CreationClassName = mo["Bandwidth"].ToString();
            //    Console.WriteLine(CreationClassName);
            //}
