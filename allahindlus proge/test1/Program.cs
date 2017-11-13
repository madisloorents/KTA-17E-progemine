using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
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

            Decimal allah1 = summa * Convert.ToDecimal(0.8);
            Console.WriteLine(allah1);
            Console.ReadLine();
        }
    }
}
