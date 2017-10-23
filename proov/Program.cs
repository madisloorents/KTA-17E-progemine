using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jagamisel kuva vastuses (mitu) komakohta? ");
            string komakoht = Console.ReadLine();

            double aste = Math.Pow(10, Convert.ToDouble(komakoht));
            Convert.ToDecimal(aste);
            Console.WriteLine(aste);
            Console.ReadLine();
        }
    }
}
