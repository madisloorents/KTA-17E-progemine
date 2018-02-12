using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scramble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See programm jätab sisestatud sõnas iga sõna esimese ja viimase tähe paigale,\naga ülejäänud muudab ära.");

            Console.Write("\nSisesta sõna: ");
            string word = Console.ReadLine();



            string eemaldus = word.Substring(1, word.Length - 2);
                        
            string scrambled_word = ScrambleWord(eemaldus);

            string viimanetaht = word.Substring(word.Length - 1);
            
            string esimenetaht = word.Substring(0,1);

            Console.WriteLine(scrambled_word);
            Console.ReadLine();
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
