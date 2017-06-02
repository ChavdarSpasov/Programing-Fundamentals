using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();

            var newList = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                var result = input[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < result.Length; j++)
                {
                    newList.Add(result[j]);
                }
                
            }

            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
