using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var allPyradim = new List<string>();
        var input = new string[n];

        for (int i = 0; i < n; i++)
        {
            var currInput = Console.ReadLine();

            input[i] = currInput;

        }

        for (int i = 0; i < input.Length; i++)
        {
            var currLine = input[i];

            for (int j = 0; j < currLine.Length; j++)
            {
                var currchar = currLine[j];
                var charSequance = 1;

                var currPyramid = string.Empty;

                for (int k = i; k < input.Length; k++)
                {
                    var currSimbol = new string(currchar, charSequance);

                    if (input[k].Contains(currSimbol))
                    {
                        currPyramid += currSimbol + "\r\n";
                    }
                    else
                    {
                        break;
                    }

                    charSequance += 2;
                }

                allPyradim.Add(currPyramid);

            }
        }

        allPyradim = allPyradim.OrderByDescending(x => x.Length).ToList();
        Console.WriteLine(allPyradim[0]);
    }
}

