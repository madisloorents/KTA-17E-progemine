using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hangman
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Arvutil on mälus mõned sõnad. Paku tähti, et alustada ühe sõna äraarvamist.\nValesti võid pakkuda 5 korda. Esimene sõna on selline: ");
            Console.WriteLine();
            

            string[] sonad = {"R A K U L K A", "S A V I S A A R", "S A L E B U S", "K A I K R A I D E R", "N A K S T I", "H O P S T I" };
                        
            int random_vastussona = new Random().Next(0, sonad.Length);



            Console.WriteLine();            
            Console.WriteLine(sonad[random_vastussona]);
            Console.WriteLine();

            Console.WriteLine("Sisesta täht: ");
            var paktaht = Console.ReadLine();
            

            

            Console.WriteLine("R _ _ _ _ _ A");
            Console.WriteLine();
            Console.Write("Sisesta täht: a");
            Console.WriteLine();
            Console.WriteLine("Õige! R A _ _ _ _ A");
            Console.WriteLine();
            Console.WriteLine("Sisesta täht: g");
            Console.WriteLine("Vale! R A _ _ _ _ A");
            Console.WriteLine("Valesti võid pakkuda veel 4 korda.");
            Console.ReadLine();
        }
    }
}
