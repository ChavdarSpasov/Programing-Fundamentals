using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var result = new Dictionary<string, List<int>>();

        var line = Console.ReadLine();

        while (line != "end")
        {
            var splitLine = line.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var name = splitLine[0];
            var volue = splitLine[1];

            if (!result.ContainsKey(name))
            {
                result[name] = new List<int>();
            }


            var resurlFromParse = 0;
            if (int.TryParse(volue, out resurlFromParse))
            {
                for (int i = 1; i < splitLine.Length; i++)
                {
                    result[name].Add(int.Parse(splitLine[i]));
                }
            }
            else
            {
                if (result.ContainsKey(volue))
                {
                    result[name] = new List<int>(result[volue]);
                    //foreach(int element in result[volue])
                    //{
                    //	result[name].Add(element);
                    //}

                }
                else
                {
                    result.Remove(name);
                }

            }


            line = Console.ReadLine();
        }


        foreach (var kvp in result)
        {
            Console.WriteLine("{0} === {1}", kvp.Key, string.Join(", ", kvp.Value));
        }

    }
}

