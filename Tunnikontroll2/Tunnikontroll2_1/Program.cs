using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm, mis lubab sisestada n+1 erinevat sõna kuni sisestatakse -1");
            Console.WriteLine();

            List<string> kuunimed = new List<string>();

            while (true)
            {
                Console.Write("Sisesta kuu nimetus: ");
                var kuunimi = Console.ReadLine();

                if (kuunimi == "-1") break;
                
                kuunimed.Add(kuunimi);
            }
                      
            Console.WriteLine();
            Console.Write($"Sisestasid järgmised kuunimed: {string.Join(", ", kuunimed)}");
            Console.WriteLine();

            var random = new Random().Next(0, kuunimed.Count - 1);
            Console.WriteLine($"Valin välja suvalise kuunime: {kuunimed[random]}");

            Console.ReadLine();
        
        }
    }
}
