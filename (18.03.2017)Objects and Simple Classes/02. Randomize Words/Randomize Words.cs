using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];
                var swap = currWord;
                var randomWord = words[random.Next(0, words.Length)];

                swap = currWord;
                currWord = randomWord;
                randomWord = swap;
                 
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
