using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;
using SystemMonitoring.GUI;

namespace SystemMonitoring.Hardware
{
    class DataMedium
    {
        private ManagementObjectSearcher dataMediumSearcher;

        public DataMedium()
        {

        }

        public List<string> AllDataMediums()
        {
            List<string> SelectionDataMedium = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject d in mos.Get())
            {
                SelectionDataMedium.Add(d["Model"].ToString());
            }
            return SelectionDataMedium;
        }

        public string GetModel(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["Model"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetMediaType(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["MediaType"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetSerialNumber(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
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

        public string GetInterfaceType(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["InterfaceType"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetSize(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    long Gesamtgroesse = long.Parse(queryObj["Size"].ToString());
                    return string.Format("{0:0.00} GB", Gesamtgroesse / 1024 / 1024 / 1024);
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetPartitions(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["Partitions"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetSignature(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["Signature"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetFirmwareRevision(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["FirmwareRevision"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetTotalCylinders(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["TotalCylinders"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetTotalSectors(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["TotalSectors"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetTotalHeads(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["TotalHeads"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetTotalTracks(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["TotalTracks"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetBytesPerSector(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["BytesPerSector"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetSectorsPerTrack(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["SectorsPerTrack"].ToString();
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public string GetTracksPerCylinder(string SelectedDataMedium)
        {
            dataMediumSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE Model = '" + SelectedDataMedium + "'");

            try
            {
                foreach (ManagementObject queryObj in dataMediumSearcher.Get())
                {
                    return queryObj["TracksPerCylinder"].ToString();
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
