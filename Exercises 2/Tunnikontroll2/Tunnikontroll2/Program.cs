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
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter price of food item [-1 to quit]: ");
            Decimal hind1 = Convert.ToDecimal(Console.ReadLine());

            hind1 = Math.Truncate(hind1 * 100) / 100;

             while (hind1 != -1)
             {
                Console.WriteLine("Enter price of food item [-1 to quit]: ");
                Decimal hind2 = Convert.ToDecimal(Console.ReadLine());

                

                if (hind2 == -1)
                {
                    Console.WriteLine("Subtotal");
                }
             }
        }
    }
}
