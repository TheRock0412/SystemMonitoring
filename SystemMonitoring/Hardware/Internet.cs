using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace SystemMonitoring.Hardware
{
    class Internet
    {
        NetworkInterface[] networkadapter;
        IPHostEntry host;

        public Internet()
        {

        }

        public string GetNetworkAdapter()
        {
            networkadapter = NetworkInterface.GetAllNetworkInterfaces();
            string netadapter = string.Empty;

            foreach (NetworkInterface adapter in networkadapter)
            {
                if (netadapter == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    netadapter = adapter.Description.ToString();
                    netadapter = netadapter.Replace("(", "[");
                    netadapter = netadapter.Replace(")", "]");
                }
            }
            return netadapter;
        }

        public string GetGateway()
        {
            string Gateway = string.Empty;

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        Gateway = d.Address.ToString();
                    }
                }
            return Gateway;
        }

        public string GetVerbindungstyp()
        {
            networkadapter = NetworkInterface.GetAllNetworkInterfaces();
            string networkname = string.Empty;

            foreach (NetworkInterface adapter in networkadapter)
            {
                if (networkname == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    networkname = adapter.Name.ToString();
                }
            }
            return networkname;
        }

        public string GetDNSSurffix()
        {
            networkadapter = NetworkInterface.GetAllNetworkInterfaces();
            string HostName = string.Empty;

            foreach (NetworkInterface adapter in networkadapter)
            {
                if (HostName == string.Empty)
                {
                    HostName = adapter.GetIPProperties().DnsSuffix;
                }
            }
            return HostName;
        }

        public string GetIPAddress4()
        {
            host = Dns.GetHostEntry(Dns.GetHostName()); ;
            string IPv4 = string.Empty;

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPv4 = ip.ToString();
                }
            }
            return IPv4;
        }

        public string GetIPAddress6()
        {
            host = Dns.GetHostEntry(Dns.GetHostName());
            string IPv6 = string.Empty;

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    IPv6 = ip.ToString();
                }
            }
            return IPv6;
        }

        public string GetMACAddress()
        {
            networkadapter = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;

            foreach (NetworkInterface adapter in networkadapter)
            {
                if (sMacAddress == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            var output = string.Join(":", Enumerable.Range(0, 6).Select(i => sMacAddress.Substring(i * 2, 2)));
            return output;
        }
    }
}