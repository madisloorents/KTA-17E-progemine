using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodutoo_5_I_sess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random arvr = new Random();
            int arv = arvr.Next(1, 101);

            Console.WriteLine("Mul on mälus täisarv, mis on arvude 1 ja 100 vahel. Arva ära, mis arv see on!");
            Console.WriteLine();
            Console.Write("Sisesta alustuseks üks arv: ");
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
                Console.WriteLine("Leidsidki kohe õige arvu! Tubli! \n");
                Console.WriteLine("Press any key to continue!");
                Console.ReadLine();
                return;
            }

            while (guess != arv)
            {
                Console.WriteLine("\nProovi veel!");
                Console.Write("Sisesta uus arv: ");
                int guess1 = int.Parse(Console.ReadLine());

                if (guess1 < arv)
                {
                    Console.WriteLine("\nÕige arv on suurem!");
                }

                if (guess1 > arv)
                {
                    Console.WriteLine("\nÕige arv on väiksem!");
                }

                if (guess1 == arv)
                {
                    Console.WriteLine("\n\nLeidsid õige arvu! \n");
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadLine();
                    return;

                }
            }
        }
    }
}
