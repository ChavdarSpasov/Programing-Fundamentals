using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            List<string> foundwords = new List<string>();
            List<int> occurrences = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];

                if (!foundwords.Contains(currWord))
                {
                    foundwords.Add(currWord);
                    occurrences.Add(1);
                }
                else
                {
                    var indexOfContainedCurrWord = foundwords.IndexOf(currWord);
                    occurrences[indexOfContainedCurrWord]++;
                }
            }

            bool Swap = true;
            while (Swap)
            {
                Swap = false;

                for (int i = 0; i < occurrences.Count -1; i++)
                {
                    if (occurrences[i] < occurrences[i + 1])
                    {
                        
                        var swapInt = occurrences[i];
                        occurrences[i] = occurrences[i + 1];
                        occurrences[i + 1] = swapInt;

                        var swapWord = foundwords[i];
                        foundwords[i] = foundwords[i + 1];
                        foundwords[i + 1] = swapWord;
                     
                        Swap = true;
                    }
                }
               
            }


            for (int i = 0; i < foundwords.Count; i++)
            {
                var percentage = (occurrences[i] * 100.0) / words.Length ;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", foundwords[i], occurrences[i], percentage);
            }


            
        }
    }
}
