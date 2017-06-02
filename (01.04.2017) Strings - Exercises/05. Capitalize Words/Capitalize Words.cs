using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        while (input != "end")
        {
            var words = input.Split(new char[] { ' ', ',', '.', ':', ';', '[', ']', '{', '}', '"', '\\', '(', ')', '-', '=', '>', '<', '~', '|', '`', '?', '!', '/', '*', '%', '$', '#', '@', '^', '&' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();

            var result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Equals(string.Empty))
                {
                    words[i] = UpperCaseFirst(words[i]);
                    result.Add(words[i]);
                }
            }

            Console.WriteLine(string.Join(", ",result));

            input = Console.ReadLine();
        }
    }

    public static string UpperCaseFirst(string x)
    {
        if (string.IsNullOrEmpty(x))
        {
            return string.Empty;
        }

        var a = x.ToCharArray();
        a[0] = char.ToUpper(a[0]);

        return new string(a);
       
    }
}
       