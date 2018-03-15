using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring.Hardware
{
    class Ethernet
    {

        public Ethernet()
        {

        }

        public static string GetNetworkAdapter()
        {
            NetworkInterface[] networkadapter = NetworkInterface.GetAllNetworkInterfaces();
            String netadapter = string.Empty;

            foreach (NetworkInterface adapter in networkadapter)
            {
                if (netadapter == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    netadapter = adapter.Description.ToString();
                }
            }
            return netadapter;
        }

        public static string GetGateway()
        {
            String Gateway = "";

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

        public static string GetVerbindungstyp()
        {
            NetworkInterface[] networkadapter = NetworkInterface.GetAllNetworkInterfaces();
            String networkname = string.Empty;

            foreach (NetworkInterface adapter in networkadapter)
            {
                if (networkname == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    networkname = adapter.Name.ToString();
                }
            }
            return networkname;
        }

        public static string GetDNSSurffix()
        {
            NetworkInterface[] dnsname = NetworkInterface.GetAllNetworkInterfaces();
            string HostName = string.Empty;

            foreach (NetworkInterface adapter in dnsname)
            {
                if (HostName == string.Empty)
                {
                    HostName = adapter.GetIPProperties().DnsSuffix;
                }
            }
            return HostName;
        }

        public static string GetIPAddress4()
        {
            IPHostEntry host;

            string IPv4 = "";

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPv4 = ip.ToString();
                }
            }
            return IPv4;
        }

        public static string GetIPAddress6()
        {
            IPHostEntry host;
            string IPv6 = "";

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    IPv6 = ip.ToString();
                }
            }
            return IPv6;
        }

        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;

            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)
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
