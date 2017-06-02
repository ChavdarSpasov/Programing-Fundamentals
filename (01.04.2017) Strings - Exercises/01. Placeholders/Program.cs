using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            while (text != "end")
            {

                var index = text.IndexOf("->");

                var sentance = text.Substring(0, index);
                var playsholders = text.Substring(index + 2).Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (text.Contains("{"))
                {
                    for (int i = 0; i < playsholders.Length; i++)
                    {
                        sentance = sentance.Replace($"{{{i}}}", playsholders[i]);
                    }
                }

                Console.WriteLine(sentance);

                text = Console.ReadLine();
            }

        }

    }
}
