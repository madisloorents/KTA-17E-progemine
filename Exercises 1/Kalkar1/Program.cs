using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen Sulle nende summa");
            Console.WriteLine();

            Console.Write("Esimene number: ");
            string number1 = Console.ReadLine();
           
            Console.Write("Teine number: ");
            string number2 = Console.ReadLine();

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            Console.WriteLine();
            
            Console.WriteLine("Tulemuseks on: " + (num1 + num2));
            Console.WriteLine();            
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();

        }
    }
}
