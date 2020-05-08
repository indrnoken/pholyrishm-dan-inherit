using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pholyrism
{
    class Program
    {
        static void Main(string[] args)
        {
            printer printer;

            Console.WriteLine("\t| jenis printer | ");
            Console.WriteLine(" 1. canon");
            Console.WriteLine("2.epson");
            Console.WriteLine("3.laserjet");
            Console.Write("piliha printer (1..3) :");

            int pilihprinter = Convert.ToInt32(Console.ReadLine());

            if (pilihprinter == 1)
                printer = new canon();
            else if (pilihprinter == 2)
                printer = new epson();
            else
                printer = new laserjet();
        }
    }
}
