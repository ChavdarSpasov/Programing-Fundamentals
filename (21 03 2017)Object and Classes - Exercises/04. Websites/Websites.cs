using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Websites
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var result = new List<Website>();

            while (line != "end")
            {
                var websiteData = ReadLine(line);
                result.Add(websiteData);

                line = Console.ReadLine();
            }

            foreach (var x in result)
            {
                if (x.Queries.Count() == 0)
                {
                    Console.WriteLine("https://www.{0}.{1}", x.Host, x.Domain);
                }
                else if (x.Queries.Count() > 0)
                {
                    Console.Write("https://www.{0}.{1}/query?=", x.Host, x.Domain);

                    for (int i = 0; i < x.Queries.Count(); i++)
                    {
                        if (i == x.Queries.Count() - 1)
                        {
                            Console.Write("[{0}]", x.Queries[i]);
                        }
                        else
                        {
                            Console.Write("[{0}]&", x.Queries[i]);
                        }

                    }

                    Console.WriteLine();

                }
            }
        }

        public static Website ReadLine(string text)
        {
            var newText = text.Split(new char[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new Website { Host = newText[0], Domain = newText[1], Queries = newText.Skip(2).ToList() };
        }

    }
}
