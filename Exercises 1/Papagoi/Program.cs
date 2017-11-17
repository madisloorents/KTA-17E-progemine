using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papagoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen papagoi programm. Ütle mulle midagi ja ma kordan selle Sulle tagasi...");
            Console.WriteLine();
            Console.Write("Sina ütled: ");
            
            string input = Console.ReadLine();

            Console.WriteLine("Mina ütlen: " + input);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
