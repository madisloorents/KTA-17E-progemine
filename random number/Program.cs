using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int number1 = number.Next(1, 3);
            Console.WriteLine(number1);
            Console.ReadLine();
        }
    }
}
