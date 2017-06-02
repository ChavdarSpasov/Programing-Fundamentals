using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInput = Console.ReadLine().Split();
            var listInput = new List<int>();
            for (int i = 0; i < arrInput.Length; i++)
            {
                var currArr = arrInput[i];
                listInput.Add(int.Parse(currArr));
            }

            var smallesElement = int.MaxValue;

            foreach (var input in listInput)
            {
                if (input<smallesElement)
                {
                    smallesElement = input;
                }
            }

            Console.WriteLine(smallesElement);
        }
    }
}
