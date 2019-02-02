using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SerwerDB
{
    public class SocketListener
    {

        public static string data = null;

        static void StartListening()
        {

            //Pobieram ip dla hosta i ustawiam endpointa dla socketa.
            IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ipAddress, 10100);
            TcpClient client = default(TcpClient);
            


            try
            {
                server.Start();
                Console.WriteLine("Czekam na konroler...");

            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            while (true)
            {
                client = server.AcceptTcpClient();

                byte[] receivedBuffer = new byte[4];
                NetworkStream stream = client.GetStream();

                stream.Read(receivedBuffer, 0, receivedBuffer.Length);

                int msg = BitConverter.ToInt32(receivedBuffer, 0);

                Console.Clear();
                Console.WriteLine(msg);

            }
        }

        public static int Main()
        {
            StartListening();
            return 0;
        }
    }
}