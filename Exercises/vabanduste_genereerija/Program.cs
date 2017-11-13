using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vabanduste_genereerija
{
    class Program
    {
        static void Main(string[] args)
        {
            // prindi: vabanduste genereerimise programm
            // prindi: sisesta komadega eraldatud vabandused:
            // prindi: > ja saa kasutaja sisend

            // oletame, et kasutaja sisestab oma vabandused ...

            // massiiv = input.Split(',')

            // int random = new Random().Next... (0, massiiv.Lenght)?

            // prindi: Tänane vabandus on: {massiiv[random]}



            Console.WriteLine("Sisesta komadega eraldatud vabandused: ");
            Console.Write("> ");
            var vabandused = Console.ReadLine();

            var massiiv = vabandused.Split(',');

            int random = new Random().Next(0, massiiv.Length);

            Console.WriteLine("Tänane vabandus on: " + massiiv[random]);
            Console.ReadLine();
        }
    }
}
