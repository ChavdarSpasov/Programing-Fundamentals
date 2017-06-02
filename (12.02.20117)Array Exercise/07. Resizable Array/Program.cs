using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[4];
            int[] resul = new int[5];
            var currInput = Console.ReadLine();

            while (currInput != "end")
            {
                switch (currInput)
                {
                    case currInput[0] == "push":
                        add number to end;
                        break;
                    case currInput[0] == "pop":
                        remove last number;
                        break;
                    case currInput[0] == "removeAt":                                      remove number at index;
                        break;        
                }


                currInput = Console.ReadLine();
            }




        }
    }
}
