using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EksamenUDP
{
    internal class Listener
    {
        private int PORT;

        public Listener(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            using (UdpClient client = new UdpClient(PORT))
            {
                IPEndPoint AfsenderEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receive = client.Receive(ref AfsenderEP);

                Console.WriteLine("Modtaget fra " + AfsenderEP.Address + " " + AfsenderEP.Port);
                String str = Encoding.ASCII.GetString(receive);
               
                Console.WriteLine("Modtaget \n" + str);

             
            }


        }
    }
}
