using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitoring
{
    class ServerConnection
    {
        static string Host = "192.168.100.94";
        static int Port = 9000;

        static TcpClient client;

        public ServerConnection()
        {

        }

        public static void OpenConnection()
        {
            if (client != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----- Es besteht bereits eine Verbindung mit dem Server " + Host + " -----");
            }
            else
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(Host, Port);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Verbindung konnte erfolgreich aufgebaut werden...");
                }
                catch (Exception ex)
                {
                    client = null;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Verbindung konnte nicht aufgebaut werden. Msg: " + ex.Message);
                }
            }
        }

        public static void SendData(string data)
        {
            if (client == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-- Es besteht keine Verbindung zum Server!");
                return;
            }

            //Daten werden gesendet
            NetworkStream nmStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(data);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Daten: " + data);
            nmStream.Write(bytesToSend, 0, bytesToSend.Length);

            //Daten werden erhalten
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nmStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Erhaltene Daten: " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            nmStream.Write(bytesToSend, 0, bytesToSend.Length);
        }

        public static void CloseConnection()
        {
            if (client == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----- Es ist keine Verbindung vorhanden -----");
                return;
            }

            try
            {
                client.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                client = null;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----- Verbindung wurde erfolgreich getrennt -----");
        }
    }
}