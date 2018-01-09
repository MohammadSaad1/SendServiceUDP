using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamenUDP
{
    class Program
    {
        private const int PORT = 2605;
        static void Main(string[] args)
        {
           Listener m = new Listener(PORT);
            m.Start();

            Console.ReadLine();
        }

    }
}
