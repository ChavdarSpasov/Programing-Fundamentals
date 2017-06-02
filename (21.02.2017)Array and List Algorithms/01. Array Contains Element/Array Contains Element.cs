using System;
using System.Collections.Generic;


namespace _01.Array_Contains_Element
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

            var numberToCheck = int.Parse(Console.ReadLine());

            var elementContained = false;
            
                for (int i = 0; i < listInput.Count; i++)
                {
                    if (listInput[i] == numberToCheck)
                    {
                        elementContained = true;
                        Console.WriteLine("yes");
                        break;
                    }

                
                }
            if (elementContained !=true)
            {
                Console.WriteLine("no");
            }
       

        }
    }
}
