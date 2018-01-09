using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDPSender
{
   internal class SenderService
    {
        private readonly int PORT;

        public SenderService(int port)
        {
            PORT = port;
        }

        public void Start()
        {
            Random rnd = new Random();
            

            while (true)
            {
                int outgoing = rnd.Next(0, 10);
                int ingoing = rnd.Next(0, 10);

                // Sender
                String SenderStr = $"Door: 10 \r\n Out:{outgoing} \r\n In:{ingoing}";
            byte[] buffer = Encoding.ASCII.GetBytes(SenderStr);

            UdpClient udp = new UdpClient();

            IPEndPoint OtherEP = new IPEndPoint(IPAddress.Broadcast, PORT);
            udp.Send(buffer, buffer.Length, OtherEP);

            IPEndPoint ReceicerEP = new IPEndPoint(IPAddress.Any, 0);
               
                Thread.Sleep(5000);
            }



        }
    }
}
