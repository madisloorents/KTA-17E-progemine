using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm, mis lubab sisestada n+1 erinevat sõna kuni sisestatakse sõna stop");
            Console.WriteLine();
                        
            List<string> kuu = new List<string>();
                      
            
            while (true)
            {
                
                Console.Write("Sisesta kuu nimetus: ");
                string kuunimi = Console.ReadLine();
                kuu.Add(kuunimi);

                if (kuunimi == "stop")
                {
                    break;
                }
                
            }
            kuu.Remove("stop");
            

            string[] kuukoos = kuu.ToArray();

            var kuukoos2 = string.Join(", ", kuukoos);

            int random = new Random().Next(0, kuukoos.Length);

            

            Console.WriteLine();

            Console.WriteLine("Sisestasid sõnad: " + kuukoos2);
            Console.WriteLine();
            Console.WriteLine("Valin välja suvalise: " + kuukoos[random]);
            Console.ReadLine();

            
            

                        
            

        }
    }
}
