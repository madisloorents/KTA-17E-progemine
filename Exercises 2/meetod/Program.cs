using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreetings("Kalle", 5);

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }

        static void PrintGreetings(string a1, int a2)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Hey {a1} oled {a2} aastane");
        }
    }
}
