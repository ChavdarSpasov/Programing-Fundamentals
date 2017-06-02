using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var result = new Dictionary<string, HashSet<string>>();

        var line = Console.ReadLine();

        while (line != "filter")
        {
            var splitLine = line.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var topic = splitLine[0];


            if (!result.ContainsKey(topic))
            {
                result[topic] = new HashSet<string>();

            }

            for (int i = 1; i < splitLine.Length; i++)
            {
                result[topic].Add(splitLine[i]);
            }


            line = Console.ReadLine();
        }

        var sequance = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToArray();



        foreach (var item in result)
        {
            bool print = false;

            for (int i = 0; i < sequance.Length; i++)
            {
                if ((item.Value.Contains(sequance[i])))
                {
                    print = true;
                }
                else
                {
                    print = false;
                    break;
                }
            }


            if (print)
            {
                Console.Write("{0} | ", item.Key);
                Console.WriteLine("#" + string.Join(", #", item.Value));

            }
        }
    }
}
