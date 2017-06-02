using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var splitInput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var keyPart = splitInput[0];
                var voluePart = splitInput[1];

                result[keyPart] = voluePart;

                input = Console.ReadLine();
            }

            var defVolue = Console.ReadLine();

            var changeDic = new Dictionary<string,string>();
            var unchangeDic = new Dictionary<string, string>();
            foreach (var item in result)
            {
                if (item.Value == "null")
                {
                    changeDic[item.Key] = defVolue;                   
                }
                else
                {
                    unchangeDic[item.Key] = item.Value;
                }
               
            }

            

            unchangeDic = unchangeDic
                .OrderByDescending(x => (x.Value).Length)
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var kvp in unchangeDic)
            {
                Console.Write(kvp.Key + " <-> ");
                Console.WriteLine(kvp.Value);
            }

            foreach (var kvp in changeDic)
            {
                Console.Write(kvp.Key + " <-> ");
                Console.WriteLine(kvp.Value);
            }
           
            

        }
    }
}
