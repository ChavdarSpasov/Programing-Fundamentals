using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phone = Console.ReadLine().Split(' ');
            
            string[] names = Console.ReadLine().Split(' ');

            while (true)
            {
                string currInput = Console.ReadLine();

                if (currInput == "done")
                {
                    break;
                }
                else
                {
                    int index = Array.IndexOf(names, currInput);
                    if(index > -1)
                    {
                        Console.WriteLine($"{currInput} -> {phone[index]}");
                        
                    }

                }
                
            }
        }
    }
}
