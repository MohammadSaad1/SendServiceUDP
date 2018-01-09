using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPReceiver
{
    internal class Listener
    {
        private int PORT;
        public List<string> Liststring = new List<string>();
        string doors;
        string outgoing;
        string ingoing;
        public Listener(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            
            using (UdpClient client = new UdpClient(PORT))
            {
                while(true)
                { 
                IPEndPoint AfsenderEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receive = client.Receive(ref AfsenderEP);

                Console.WriteLine("Modtaget fra " + AfsenderEP.Address + " " + AfsenderEP.Port);
                String str = Encoding.ASCII.GetString(receive);

               
                char[] delimiterChars = {};

                string[] words = str.Split(delimiterChars);

                foreach (string s in words)
                {
                    Liststring.Add(s);
                }
               
                doors = Liststring[1];
                outgoing = Liststring[2];
                ingoing = Liststring[4];
                
                Console.WriteLine("Modtaget \n" + str);
           

                    
            }
            }


        }
    }
}
