using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodutoo_3_I_sess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random arvr = new Random();
            int arv = arvr.Next(1, 101);

            Console.WriteLine("Mul on mälus täisarv, mis on vahemikus 1 - 100. Arva ära, mis arv!");
            Console.WriteLine();

            Console.Write("Sisesta arv: ");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine();

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

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
    }
}
