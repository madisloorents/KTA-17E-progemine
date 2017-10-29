using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodutoo_1_I_sess
{
    class Program
    {
        static void Main(string[] args)
        {
            int arv = 56;

            Console.WriteLine("Mul on mälus üks positiivne täisarv, mis on arvude 1 ja 100 vahel. \nProovi see ära arvata!");
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

            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
        }
    }
}
