using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitoring.Hardware
{
    class Datenträger
    {
        public Datenträger()
        {

        }

        static public string DatenträgerName
        {
            get
            {
                try
                {
                    return "DatenträgerName";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }
    }
}
