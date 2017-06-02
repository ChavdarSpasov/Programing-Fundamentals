using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_of_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
           
            var capitalLetters = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                if (word.Length == 1)
                {
                    word.ToCharArray();
                    if (word[0]>64 && word[0]<91)
                    {
                        capitalLetters++;
                    }
                }  
                                  
            }

            Console.WriteLine(capitalLetters);
        }
    }
}
