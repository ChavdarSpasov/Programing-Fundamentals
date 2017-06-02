using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var currName = Console.ReadLine();
                set.Add(currName);
               
            }

           
            Console.WriteLine(string.Join(Environment.NewLine,set));
            
        }
    }
}
