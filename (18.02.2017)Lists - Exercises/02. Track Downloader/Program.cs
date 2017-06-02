using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackListedWords = Console.ReadLine().Split(' ').ToList();


            List<string> output = new List<string>();

            string fileNames = Console.ReadLine();

            while (fileNames != "end")
            {
                bool notMatch = true;

                for (int i = 0; i < blackListedWords.Count; i++)
                {
                    if (fileNames.Contains(blackListedWords[i]))
                    {
                        notMatch = false;
                        break;
                    }                         
                }

                if (notMatch)
                {
                    output.Add(fileNames);
                }

                fileNames = Console.ReadLine();

            }

            output.Sort();

            foreach (var element in output)
            {

                Console.WriteLine(element);
            }
        }
    }
}
