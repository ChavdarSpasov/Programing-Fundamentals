using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var listOfPolindromes = new HashSet<string>();

            foreach (var item in words)
            {
                var currWord = item;
                bool currWordIsPolindrom = true;

                for (int i = 0; i < (currWord.Length) / 2; i++)
                {
                    var firstElement = i;

                    var lastElement = currWord.Length - 1 - i;

                    if (currWord[firstElement] == currWord[lastElement])
                    {
                        currWordIsPolindrom = true;
                    }
                    else
                    {
                        currWordIsPolindrom = false;

                        break;
                    }

                 }

                if (currWordIsPolindrom)
                {
                    listOfPolindromes.Add(currWord);        
                }
                
            }

            Console.WriteLine(string.Join(", ", listOfPolindromes.OrderBy(x=>x).ToList()));




        }
    }
}
