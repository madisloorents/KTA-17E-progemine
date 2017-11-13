using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allahindlus_proge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on allahindluse programm, sisesta summa, mis on suurem või võrdne 50 euroga.");
            Console.WriteLine();
            Console.Write("Sisesta summa: ");
            Decimal summa = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            if (summa < 250 && summa >= 50)
            {

                Decimal allah1 = summa * Convert.ToDecimal(0.9);
                Decimal allah2 = summa * Convert.ToDecimal(0.8);

                allah1 = Math.Truncate(allah1 * 100) / 100;
                allah2 = Math.Truncate(allah2 * 100) / 100;

                Console.WriteLine("Tavakliendi allahindlus");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Allahindlus: 10%");
                Console.WriteLine("Tasuda: " + allah1);

                Console.WriteLine();

                Console.WriteLine("Püsikliendi allahindlus");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Allahindlus: 20%");
                Console.WriteLine("Tasuda: " + allah2);
                

                Console.WriteLine();
                Console.WriteLine("Press any key to continue!");
                Console.ReadLine();
            }

            if (summa >= 250 && summa < 350)
            {
                Decimal allah3 = summa * Convert.ToDecimal(0.8);
                Decimal allah4 = summa * Convert.ToDecimal(0.7);

                allah3 = Math.Truncate(allah3 * 100) / 100;
                allah4 = Math.Truncate(allah4 * 100) / 100;

                Console.WriteLine("Tavakliendi allahindlus");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Allahindlus: 20%");
                Console.WriteLine("Tasuda: " + allah3);

                Console.WriteLine();

                Console.WriteLine("Püsikliendi allahindlus");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Allahindlus: 30%");
                Console.WriteLine("Tasuda: " + allah4);
                

                Console.WriteLine();
                Console.WriteLine("Press any key to continue!");
                Console.ReadLine();
            }

            if (summa >= 350)
            {
                Decimal allah5 = summa * Convert.ToDecimal(0.7);
                Decimal allah6 = summa * Convert.ToDecimal(0.6);

                allah5 = Math.Truncate(allah5 * 100) / 100;
                allah6 = Math.Truncate(allah6 * 100) / 100;

                Console.WriteLine("Tavakliendi allahindlus");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Allahindlus: 30%");
                Console.WriteLine("Tasuda: " + allah5);

                Console.WriteLine();

                Console.WriteLine("Püsikliendi allahindlus");
                Console.WriteLine("Summa: " + summa);
                Console.WriteLine("Allahindlus: 40%");
                Console.WriteLine("Tasuda: " + allah6);
                

                Console.WriteLine();
                Console.WriteLine("Press any key to continue!");
                Console.ReadLine();
            }

            
        }
    }
}
