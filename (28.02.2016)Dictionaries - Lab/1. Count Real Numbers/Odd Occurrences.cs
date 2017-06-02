using System;
using System.Collections.Generic;


namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var myDictionary = new Dictionary<string,int>();

            var words = Console.ReadLine().ToLower().Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);


            foreach (var word in words)
            {
               
                if (!myDictionary.ContainsKey(word))
                {
                    myDictionary[word] = 0;
                }
                myDictionary[word]++;
            }

            var numberOfWors = new List<string>();

            foreach (var kvp in myDictionary)
            {
                if (kvp.Value % 2 != 0)
                {
                    numberOfWors.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ",numberOfWors));
        }
    }
}
 