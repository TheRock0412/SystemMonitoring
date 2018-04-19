using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace SystemMonitoring.Hardware
{
    public class Memory
    {
        static PerformanceCounter freeMem = new PerformanceCounter("Memory", "Available MBytes");

        static double VerfügbarerSpeicher = Math.Round(Convert.ToDouble(((freeMem.NextValue() / 1024) )), 1);
        static double GesamterSpeicher = new ComputerInfo().TotalPhysicalMemory;
        static double totalMemory = Math.Round(Convert.ToDouble(((GesamterSpeicher / 1024 / 1024 / 1024))), 1);
        static double workMemory = totalMemory - VerfügbarerSpeicher;

        public Memory() { 
              
            //Console.WriteLine("Arbeitsspeicher gesamt: " + totalMemory + " GB");
            //Console.WriteLine("Verfügbarer Arbeitsspeicher: " + VerfügbarerSpeicher + " GB");
            //Console.WriteLine("In Verwendung: " + workMemory + " GB");
        }

        static public string RAMName
        {
            get
            {
                try
                {
                    return "Test";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public double RAMVerfügbar
        {
            get
            {
                try
                {
                    return VerfügbarerSpeicher;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        static public double RAMGesamt
        {
            get
            {
                try
                {
                    return totalMemory;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        static public double RAMinVerwendung
        {
            get
            {
                try
                {
                    return workMemory;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }
    }
}