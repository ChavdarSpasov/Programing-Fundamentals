using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sentence_Split
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var delimeter = Console.ReadLine();

            var newText = text.Split(new string[] { delimeter },StringSplitOptions.None);

       


            Console.WriteLine($"[{ string.Join(", ", newText)}]");

       
        }   

    }
}
