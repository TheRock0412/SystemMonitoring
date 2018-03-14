using Microsoft.Win32;
using System;
using System.Diagnostics;


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

        static public string CPUName
        {
            get
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
        }

        //static public Double CPUSpeed
        //{
        //    get
        //    {
        //        try
        //        {
        //            return Math.Round(Convert.ToDouble((((double)RegKey.GetValue("~MHz") / 1000))), 1);
        //        }
        //        catch (Exception e)
        //        {
        //            return 0;
        //        }
        //    }
        //}

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
