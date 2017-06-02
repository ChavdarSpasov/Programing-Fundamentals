using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        var firstLineToInsertInResultList = Console.ReadLine().Split().Select(int.Parse).ToList();
        var result = new List<int>(firstLineToInsertInResultList);

        var sequenceForInsertInResult = new List<int>();

        var index = 0;
        bool isBreakIncreasing = false;

        for (int i = 0; i < number - 1; i++)
        {
            sequenceForInsertInResult.Clear();
            index = 0;
            isBreakIncreasing = false;

            var commandLine = Console.ReadLine().Split().Select(int.Parse).ToList();

            sequenceForInsertInResult.Add(commandLine[0]);

            for (int j = 0; j < commandLine.Count - 1; j++)
            {
                if (commandLine[j] <= commandLine[j + 1])
                {
                    sequenceForInsertInResult.Add(commandLine[j + 1]);
                }
                else
                {
                    isBreakIncreasing = true;
                    break;
                }
            }

            //if(commandLine.Count != sequenceForInsertInResult.Count)
            //{
            //	isBreakIncreasing = true;
            //}

            for (int k = 0; k < result.Count; k++)
            {
                if (result[k] <= sequenceForInsertInResult[0])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            result.InsertRange(index, sequenceForInsertInResult);

            if (isBreakIncreasing)
            {
                var startIndex = index + sequenceForInsertInResult.Count;
                var removeNumberToEndTheList = result.Count - (index + sequenceForInsertInResult.Count);

                result.RemoveRange(startIndex, removeNumberToEndTheList);
            }
        }


        Console.WriteLine(string.Join(" ", result));


    }
}