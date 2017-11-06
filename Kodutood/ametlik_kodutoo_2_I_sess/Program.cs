using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodutoo2_I_sess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta suvalise ringi raadius kümnendmurruna sentimeetrites (nt kujul 3,4) \n\nja saad, kui suur on ringi pindala, ümbermõõt vajaliku täpsusega.");
            Console.WriteLine();
            Console.Write("Sisesta raadiuse pikkus: ");
            Decimal raadius = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Sisesta, mitu komakohta soovid ringi ümbermõõdu arvutuses näha: ");
            Decimal tapsus = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Sisesta, mitu komakohta soovid ringi pindala arvutuses näha: ");
            Decimal tapsus2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Decimal ringipikk = 2 * Convert.ToDecimal(Math.PI) * raadius;

            ringipikk = Math.Truncate(ringipikk * Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus)))) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus)));


            Decimal ringipind = Convert.ToDecimal(Math.PI) * raadius * raadius;

            ringipind = Math.Truncate(ringipind * Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus2)))) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus2)));

            Console.WriteLine();
            Console.WriteLine("Ringi ümbermõõt on " + ringipikk + " cm");
            Console.WriteLine();
            Console.WriteLine("Ringi pindala on " + ringipind + " cm^2 \n\n");

            Console.WriteLine("Kas soovite veel mõne ringi pindala või ümbermõõtu leida? Vasta 'jah' või 'ei'. ");
            string vastus1 = Console.ReadLine();
                                                
            while (vastus1 == "jah") 
            {
                Console.Write("\n\nSisesta raadiuse pikkus: ");
                Decimal raadius2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Sisesta, mitu komakohta soovid ringi ümbermõõdu arvutuses näha: ");
                Decimal tapsus3 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Sisesta, mitu komakohta soovid ringi pindala arvutuses näha: ");
                Decimal tapsus4 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine();

                Decimal ringipikk2 = 2 * Convert.ToDecimal(Math.PI) * raadius2;

                ringipikk2 = Math.Truncate(ringipikk2 * Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus3)))) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus3)));


                Decimal ringipind2 = Convert.ToDecimal(Math.PI) * raadius2 * raadius2;

                ringipind2 = Math.Truncate(ringipind2 * Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus4)))) / Convert.ToDecimal(Math.Pow(10, Convert.ToDouble(tapsus4)));

                Console.WriteLine();
                Console.WriteLine("Ringi ümbermõõt on " + ringipikk2 + " cm");
                Console.WriteLine();
                Console.WriteLine("Ringi pindala on " + ringipind2 + " cm^2 \n\n");
                Console.WriteLine();
                Console.WriteLine("Kas soovite veel mõne ringi pindala või ümbermõõtu leida? Vasta 'jah' või 'ei'. ");
                string vastus2 = Console.ReadLine();
                                
                if (vastus2 == "ei")
                {
                    Console.WriteLine("\n\nPress any key to continue!");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("\n\nPress any key to continue!");
            Console.ReadLine();

        }
    }
}
