using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodutoo_2_I_sess
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv = 54;

            Console.WriteLine("Mul on mälus üks täisarv vahemikust 1 - 100. Ära see ära!");
            Console.WriteLine();

            Console.Write("Sisesta arv: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < arv)
            {
                Console.WriteLine("Õige arv on suurem!");
            }
            
            if (guess > arv)
            {
                Console.WriteLine("Õige arv on väiksem!");
            }

            if (guess == arv)
            {
                Console.WriteLine("Leidsidki õige arvu!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
    }
}
