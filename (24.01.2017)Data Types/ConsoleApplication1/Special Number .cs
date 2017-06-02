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
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n + 1; i++)
            {
                int currNum = i;
                int sum = 0;
                while (currNum > 0)
                {
                    int lastNum = currNum % 10;
                    currNum /= 10;
                    sum += lastNum;
                }

                bool result = (sum == 7 || sum == 5 || sum == 11);

                Console.WriteLine($"{i}-->{result}");
            }
            

            

        }
    }
}
