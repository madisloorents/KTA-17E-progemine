using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suurem_vordne_vaiksem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number0 = new Random();
            int number = number0.Next(1, 21);

            Console.WriteLine("Arva ära, milline täisarv mul mälus on. See täisarv on arvude 0 ja 20 vahel. \n");
            Console.Write("Sisesta alustuseks üks täisarv: ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != number)
            {
                                    
                    Console.WriteLine("\n\nProovi veel!\n");
                    
                    Console.Write("Sisesta arv: ");
                    int guess1 = int.Parse(Console.ReadLine());

                    if (guess1 < number)
                    {
                        Console.WriteLine("Õige arv on suurem!");
                    }

                    if (guess1 > number)
                    {
                        Console.WriteLine("Õige arv on väiksem!");
                    }

                    if (guess1 == number)
                    {
                    Console.WriteLine("Leidsidki õige arvu! Tubli! \n");
                    
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                    return;
                    }

                
            }
                    
            Console.WriteLine("\n\nSisestasid kohe õige arvu! Tubli! \n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
