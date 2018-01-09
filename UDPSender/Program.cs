using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPSender
{
    class Program
    {
        private const int PORT = 2605;


        static void Main(string[] args)
        {
            SenderService service = new SenderService(PORT);
            service.Start();

            Console.ReadLine();
        }
    }
}
