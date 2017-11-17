using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6by6_korrutamine
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6;i++)
            {
                Console.Write(i + "\t");

                for (int j = 0; j <= 6; j++)
                {
                    if (i > 0)
                    {
                        Console.Write(i * j + "\t");                   
                    }
                    else
                    {
                        Console.Write(j + "\t");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        
    }
}
