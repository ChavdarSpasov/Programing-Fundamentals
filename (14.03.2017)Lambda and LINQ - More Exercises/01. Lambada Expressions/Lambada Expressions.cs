using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string,string>>();

            var input = Console.ReadLine();


            while (input != "lambada")
            {
                var splitInput = input.Split(new char[] { '=', '>', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (splitInput.Length != 1)
                {
                   
                    var selector = splitInput[0];
                    var objectSelector = splitInput[1];
                    var property = splitInput[2];

                    if (!dictionary.ContainsKey(selector))
                    {
                        dictionary[selector] = new Dictionary<string, string>();
                    }  

                    dictionary[selector][objectSelector] = property;

                }
                else
                {
                    dictionary = dictionary
                        .ToDictionary(x => x.Key, x => x.Value
                        .ToDictionary(y =>y.Key, y => y.Key + "." +y.Value));      
                }

                input = Console.ReadLine();

            }


            //foreach (var item in dictionary)
            //{
            //    foreach (var element in item.Value)
            //    {
            //        Console.WriteLine($"{item.Key} => {element.Key}.{element.Value}");
            //    }
            //}


            dictionary
                .ToList()
                .ForEach(x => x.Value
                .ToList()
                .ForEach(y => Console.WriteLine("{0} => {1}.{2}",x.Key,y.Key,y.Value)));

        }
    }
}
