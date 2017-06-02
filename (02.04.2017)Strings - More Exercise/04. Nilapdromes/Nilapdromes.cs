//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04.Nilapdromes
//{
//    class Nilapdromes
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();

//            var borderEnd = string.Empty;
//            var borderFrond = string.Empty;
//            var body = string.Empty;

//            var cheker = input;

//            var index = 0;
//            while (input != "end")
//            {
//                var currWord = input.First();
//                var borderFound = false;


//                index = input.LastIndexOf(currWord);

//                //Console.WriteLine(index);
//                borderEnd = input.Substring(index);
//                borderFrond = input.Substring(0, borderEnd.Length);
//                body = input.Replace(borderFrond, "").Trim();


//                if (borderEnd == borderFrond && body != string.Empty)
//                {
//                    borderFound = true;
//                }
//                else
//                {
//                    while (borderFrond != borderEnd)
//                    {
//                        index = input.LastIndexOf(currWord, index - 1);
//                        borderEnd = input.Substring(index);
//                        borderFrond = input.Substring(0, borderEnd.Length);
//                        body = input.Replace(borderFrond, "").Trim();

//                    }

//                    if (borderFrond == borderEnd && body != string.Empty)
//                    {
//                        borderFound = true;
//                    }
//                }


//                //Console.WriteLine("borderEnd =" + borderEnd);
//                //Console.WriteLine("borderFrond =" + borderFrond);
//                //Console.WriteLine("body =" + body);

//                if (input.Contains(body) && input.Contains(borderFrond) && borderFound)
//                {
//                    Console.WriteLine($"{input}->{string.Concat(body, borderEnd, body)}");

//                }

//                input = Console.ReadLine();
//            }



//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var borderFirst = input.Substring(0, input.Length / 2);
                var borderSecond = string.Empty;
                var border = string.Empty;

                if (input.Length % 2 == 0)
                {
                    borderSecond = input.Substring(borderFirst.Length, input.Length - borderFirst.Length);
                }
                else
                {
                    borderSecond = input.Substring(borderFirst.Length + 1, input.Length - borderFirst.Length - 1);
                }

                while (true)
                {
                    if (borderFirst == borderSecond)
                    {
                        border = borderFirst;
                        break;
                    }
                    else if (borderFirst != borderSecond)
                    {
                        borderFirst = borderFirst.Substring(0, borderFirst.Length - 1);
                        borderSecond = borderSecond.Substring(1, borderSecond.Length - 1);
                    }

                    if (borderFirst.Length == 0 && borderSecond.Length == 0)
                    {
                        break;
                    }
                }

                if (border.Length != 0)
                {
                    var core = input.Remove(input.Length - border.Length, border.Length).Trim();
                    core = core.Remove(0, border.Length).Trim();
                    if (core != "")
                    {
                        var nilapdromes = core + border + core;
                        Console.WriteLine(nilapdromes);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}