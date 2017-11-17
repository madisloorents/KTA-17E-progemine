using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("------------------------------------");
            Console.Write("Enter price of food [-1 to quit]: ");
            Decimal hind1 = Convert.ToDecimal(Console.ReadLine());

            
            Decimal hindtotal = 0;
                        
            while (hind1 != -1)
            {
                Console.Write("Enter Price of food [-1 to quit]: ");
                Decimal hind2 = Convert.ToDecimal(Console.ReadLine());
                
                if (hind2 == -1)
                {                                                            
                    break;
                }
                hindtotal = hindtotal + hind2;
            }

            hindtotal = hindtotal + hind1;
            
            Decimal hindprot = hindtotal * Convert.ToDecimal(0.15);
            Decimal hindtotaltotal = hindtotal - hindprot;

            Decimal hindtotalround = Decimal.Round(hindtotal, 2);
            Decimal hindprotround = Decimal.Round(hindprot, 2);
            Decimal hindtotaltotalround = Decimal.Round(hindtotaltotal, 2);
                                                
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Subtotal: " + hindtotalround + " €");
            Console.WriteLine("15,00% Gratuity: " + hindprotround + " €");
            Console.WriteLine("Total: " + hindtotaltotalround + " €");
            Console.WriteLine("Press any key to contiue!");
            Console.ReadLine();


        }
    }
}
