using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm.");
            Console.WriteLine("Ütle mulle 2 numbrit ja ma ütlen Sulle nende korrutise ja jagatise.");

            Console.Write("Esimene number: ");
            string num1 = Console.ReadLine();

            Console.Write("Teine number: ");
            string num2 = Console.ReadLine();

            Console.WriteLine();

            Decimal korrutis = Convert.ToDecimal(num1) * Convert.ToDecimal(num2);

            Console.WriteLine("Korrutades " + num1 + " ja " + num2 + " on tulemuseks: " +(korrutis));

            Decimal jagatis = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);

            jagatis = Math.Truncate(jagatis * 100) / 100;

            Console.WriteLine("Jagades " + num1 + " ja " + num2 + " on tulemuseks: " + (jagatis));

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
