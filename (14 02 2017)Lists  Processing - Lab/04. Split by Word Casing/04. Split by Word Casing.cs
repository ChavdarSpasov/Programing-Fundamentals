using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lowercaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> uppercaseWords = new List<string>();

            

            

                var currList = Console.ReadLine().Split(new char[]{ ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                
                for (int i = 0; i < currList.Count; i++)
                {

                    if (IsAllLettersLowerCase(currList[i]))
                    {
                        lowercaseWords.Add(currList[i]);
                    }
                    else if (IsAllLettersUpperCase(currList[i]))
                    {
                        uppercaseWords.Add(currList[i]);
                    }
                    else
                    {
                        mixedCaseWords.Add(currList[i]);
                    }
                }

          

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ",lowercaseWords));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCaseWords));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", uppercaseWords));

        }


        public static bool IsAllLettersLowerCase(string word)
        {
            var lower = true;    
                       
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] > 96 && word[i] < 123)
                    {
                        lower = true;

                    }
                    else
                    {
                        lower = false;
                        break;
                    }

                }
           
            

            return lower;
        }

        public static bool IsAllLettersUpperCase(string word)
        {
            var lower = true;
           
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] > 64 && word[i] < 91)
                    {
                        lower = true;

                    }
                    else
                    {
                        lower = false;
                        break;
                    }

                }
          
            

            return lower;
        }

          
    }
}
