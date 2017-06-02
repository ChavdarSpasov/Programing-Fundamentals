using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var buldings = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numbersOfBulgings = buldings.Count;

            var camelBackSize = int.Parse(Console.ReadLine());


            var roundsBeforeBreakingDown = 0;

            if (camelBackSize >= numbersOfBulgings)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buldings)}");
            }
            else
            {
                while (!(numbersOfBulgings == camelBackSize))
                {
                    buldings.RemoveAt(0);
                    buldings.RemoveAt(buldings.Count - 1);

                    roundsBeforeBreakingDown++;
                    numbersOfBulgings -= 2;
                }

                Console.WriteLine($"{roundsBeforeBreakingDown} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buldings)}");
            }
        }
    }
}
