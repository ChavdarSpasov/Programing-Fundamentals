using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commmand = Console.ReadLine();

            var result = new List<int>();
            var sum = 0;

            for (int i = 0; i < listInput.Count; i++)
            {
                var currSequance = listInput[i].ToString();

                switch (commmand)
                {
                    case "Max":                      
                        var max = int.MinValue;
                        for (int j = 0; j < currSequance.Length; j++)
                        {
                            var integerOfCurrSequance = int.Parse(currSequance);
                            if (integerOfCurrSequance > max)
                            {
                                max = integerOfCurrSequance;
                            }

                            var firstElement = currSequance.Substring(0, 1);
                            currSequance = currSequance.Substring(1) + firstElement;
                        }

                        sum += max;
                        result.Add(max);
                        break;

                    case "Min":
                        
                        var min = int.MaxValue;
                        for (int j = 0; j < currSequance.Length; j++)
                        {
                            var integerOfCurrSequance = int.Parse(currSequance);
                            if (integerOfCurrSequance < min)
                            {
                                min = integerOfCurrSequance;
                            }

                            var firstElement = currSequance.Substring(0, 1);
                            currSequance = currSequance.Substring(1) + firstElement;
                        }

                        sum += min;
                        result.Add(min);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ",result));
            Console.WriteLine(sum);

        }
    }
}
