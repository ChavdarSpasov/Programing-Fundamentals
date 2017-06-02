using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text;


class Program
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine();

        var str = new StringBuilder();

        for (int i = input.Length-1; i >=0; i--)
        {
            str.Append(input[i]);
        }


        Console.WriteLine(str.ToString());
    }

}

