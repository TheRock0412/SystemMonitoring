using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitoring.Hardware
{
    class SystemInfos
    {
        public SystemInfos ()
        {
            string Computername = System.Windows.Forms.SystemInformation.ComputerName.ToString();

            Console.WriteLine("Computername: " + Computername);
        }
    }
}
