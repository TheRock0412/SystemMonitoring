using System;
using System.Management;

namespace SystemMonitoring.Hardware
{
    public class Mainboard
    {
        private ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");

        public Mainboard()
        {

        }

        public string GetProduct()
        {
            try
            {
                foreach (ManagementObject queryObj in baseboardSearcher.Get())
                {
                    return queryObj["Product"].ToString();
                }
                return "Name konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf des Namens, Fehler: " + e;
            }
        }

        public string GetSerialNumber()
        {
            try
            {
                foreach (ManagementObject queryObj in baseboardSearcher.Get())
                {
                    return queryObj["SerialNumber"].ToString();
                }
                return "Seriellen Nummer konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf der Seriellen Nummber, Fehler: " + e;
            }
        }

        public string GetVersion()
        {
            try
            {
                foreach (ManagementObject queryObj in baseboardSearcher.Get())
                {
                    return queryObj["Version"].ToString();
                }
                return "Version konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf der Version, Fehler: " + e;
            }
        }

        //public string GetInstallDate()
        //{
        //    try
        //    {
        //        foreach (ManagementObject queryObj in motherboardSearcher.Get())
        //        {
        //            return queryObj["InstallDate"].ToString();
        //        }
        //        return "Installations Datum konnte nicht ermittelt werden!";
        //    }
        //    catch (Exception e)
        //    {
        //        return "Fehler beim Abruf des Installations Datums, Fehler: " + e;
        //    }
        //}

        public string GetManufacturer()
        {
            try
            {
                foreach (ManagementObject queryObj in baseboardSearcher.Get())
                {
                    return queryObj["Manufacturer"].ToString();
                }
                return "Hersteller konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf des Herstellers, Fehler: " + e;
            }
        }

        public string GetPrimaryBusType()
        {
            try
            {
                foreach (ManagementObject queryObj in motherboardSearcher.Get())
                {
                    return queryObj["PrimaryBusType"].ToString();
                }
                return "Primäre Bus Typ konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf des Primären Bus Types, Fehler: " + e;
            }
        }

        public string GetSecondaryBusType()
        {
            try
            {
                foreach (ManagementObject queryObj in motherboardSearcher.Get())
                {
                    return queryObj["SecondaryBusType"].ToString();
                }
                return "Sekundäre Bus Typ konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf des Sekundären Bus Types, Fehler: " + e;
            }
        }

        public string GetStatus()
        {
            try
            {
                foreach (ManagementObject querObj in baseboardSearcher.Get())
                {
                    return querObj["Status"].ToString();
                }
                return "Status konnte nicht ermittelt werden!";
            }
            catch (Exception e)
            {
                return "Fehler beim Abruf des Statuses, Fehler: " + e;
            }
        }

        //public string GetRevisionNumber()
        //{
        //    try
        //    {
        //        foreach (ManagementObject queryObj in motherboardSearcher.Get())
        //        {
        //            return queryObj["RevisionNumber"].ToString();
        //        }
        //        return "Revisions Nummer konnte nicht ermittelt werden!";
        //    }
        //    catch (Exception e)
        //    {
        //        return "Fehler beim Abruf der Revisions Nummer, Fehler: " + e;
        //    }
        //}

        //public string GetPartNumber()
        //{
        //    try
        //    {
        //        foreach (ManagementObject queryObj in baseboardSearcher.Get())
        //        {
        //            return queryObj["PartNumber"].ToString();
        //        }
        //        return "Part Nummer konnte nicht ermittelt werden!";
        //    }
        //    catch (Exception e)
        //    {
        //        return "Fehler beim Abruf der Part Nummer, Fehler: " + e;
        //    }
        //}

        //public string GetModel()
        //{
        //    try
        //    {
        //        foreach (ManagementObject queryObj in motherboardSearcher.Get())
        //        {
        //            return queryObj["Model"].ToString();
        //        }
        //        return "Model konnte nicht ermittelt werden!";
        //    }
        //    catch (Exception e)
        //    {
        //        return "Fehler beim Abruf des Models, Fehler: " + e;
        //    }
        //}

        //private string ConvertToDateTime(string unconvertedTime)
        //{
        //    string convertedTime = "";
        //    int year = int.Parse(unconvertedTime.Substring(0, 4));
        //    int month = int.Parse(unconvertedTime.Substring(4, 2));
        //    int date = int.Parse(unconvertedTime.Substring(6, 2));
        //    int hours = int.Parse(unconvertedTime.Substring(8, 2));
        //    int minutes = int.Parse(unconvertedTime.Substring(10, 2));
        //    int seconds = int.Parse(unconvertedTime.Substring(12, 2));
        //    string meridian = "AM";
        //    if (hours > 12)
        //    {
        //        hours -= 12;
        //        meridian = "PM";
        //    }
        //    convertedTime = date.ToString() + "/" + month.ToString() + "/" + year.ToString() + " " +
        //    hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString() + " " + meridian;
        //    return convertedTime;
        //}
    }
}