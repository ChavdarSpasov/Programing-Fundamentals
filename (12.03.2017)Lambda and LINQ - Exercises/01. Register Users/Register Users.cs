using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Register_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, DateTime>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var currInput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = currInput[0];
                var data = currInput[1];
                var dataFormat = "d/m/yyyy";

                result[name] = DateTime.ParseExact(data, dataFormat, CultureInfo.InvariantCulture);


                input = Console.ReadLine();
            }

            result = result
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x=>x.Value)
                .ToDictionary(x => x.Key, x => x.Value);



            foreach (var item in result)
            {
                Console.WriteLine(item.Key );
                
            }
            
        }
    }
}
