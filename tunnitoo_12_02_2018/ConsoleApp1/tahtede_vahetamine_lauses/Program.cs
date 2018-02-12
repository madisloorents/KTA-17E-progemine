using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tahtede_vahetamine_lauses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm, mis muudab lauses tähtede järjekorda.");
            string word = "sinine või moos lehm musta lauda taga";

            string[] splitted = word.Split(' ');

            foreach (string word1 in splitted)
            {
                char esimene = word1[0];
                char viimane = word1[word1.Length - 1];
                string keskel = word1.Substring(1, word1.Length - 2);

                if (keskel.Length > 2 && keskel.Distinct().Count() > 1)
                {
                    string segamini = keskel;
                    while (segamini == keskel)
                    {
                        segamini = ScrambleWord(keskel);
                    }

                    Console.Write($"{esimene}{segamini}{viimane} ");
                }
                else
                {
                    Console.Write($"{word1} ");
                }           
                
                
            }

            Console.ReadKey();
        }
        
        static string ScrambleWord(string word)
        {
            char[] chars = new char[word.Length];
            Random rand = new Random(10000);
            int index = 0;
            while (word.Length > 0)
            { // Get a random number between 0 and the length of the word. 
                int next = rand.Next(0, word.Length - 1); // Take the character from the random position 
                                                          //and add to our char array. 
                chars[index] = word[next];                // Remove the character from the word. 
                word = word.Substring(0, next) + word.Substring(next + 1);
                ++index;
            }
            return new String(chars);
        }
    }
}
