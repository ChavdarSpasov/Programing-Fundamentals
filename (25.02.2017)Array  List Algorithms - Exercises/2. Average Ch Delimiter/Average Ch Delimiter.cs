using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Average_Ch_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            string stringOfElement = string.Empty;
            foreach (var index in arr)
            {
                //Console.WriteLine(index); 
            }

            foreach (var index in arr)
            {
                stringOfElement += index;
            }

            //Console.WriteLine(stringOfElement); 

            var sum = 0;
            foreach (var index in stringOfElement)
            {
                sum += index;
            }
            //Console.WriteLine(sum); 

            char delimeter = (char)(sum / stringOfElement.Length);
            //char delimeterUpper = char.ToUpper(delimeter); 

            //Console.WriteLine(delimeter); 
            //Console.WriteLine(delimeterUpper); 

            //Console.WriteLine(string.Join(" ",arr)); 

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    if ((int)delimeter > 96 && (int)delimeter < 123)
                    {
                        Console.Write(arr[i] + CharChangerToUpper(delimeter));
                    }
                    else
                    {
                        Console.Write(arr[i] + delimeter);
                    }
               
                }
            }
        }


        public static char CharChangerToUpper(char character)
        {
            var upper = 0;
            for (int i = 'a'; i < 'z'; i++)
            {
                if (character == i)
                {
                    upper = i - 32;
                }
            }


            return (char)upper;
        }





    }
}
