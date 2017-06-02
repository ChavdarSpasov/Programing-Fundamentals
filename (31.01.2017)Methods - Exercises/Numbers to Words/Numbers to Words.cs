using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > 999)
                {
                    Console.WriteLine("too large");
                }

                else if (num < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (num < 100 && num > -100)
                {
                    continue;
                }
                else
                {
                    if (num < 0)
                    {
                        num = Math.Abs(num);
                        var lastDig = num % 10;
                        num = num / 10;
                        var middleDig = num % 10;
                        num = num / 10;
                        var firstDig = num % 10;

                        if (lastDig == 0 && middleDig == 0)
                        {
                            Console.Write("minus ");
                            OneToNineToString(firstDig);
                            Console.Write("-hundred");
                        }
                        else if (lastDig == 0)
                        {
                            Console.Write("minus ");
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            TwentyToNinetyDigitToString(middleDig);
                        }
                        else if (middleDig == 1)
                        {
                            Console.Write("minus ");
                            OneToNineToString(firstDig);
                            Console.Write(" - hundred and ");
                            ElevenToNineteenDigitToString(lastDig);
                        }
                        else if (middleDig == 0)
                        {
                            Console.Write("minus ");
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            OneToNineToString(lastDig);
                        }
                        else
                        {
                            Console.Write("minus ");
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            TwentyToNinetyDigitToString(middleDig);
                            Console.Write(" ");
                            OneToNineToString(lastDig);
                        }
                    }

                    else if (num >= 0)
                    {

                        var lastDig = num % 10;
                        num = num / 10;
                        var middleDig = num % 10;
                        num = num / 10;
                        var firstDig = num % 10;

                        if (lastDig == 0 && middleDig == 0)
                        {

                            OneToNineToString(firstDig);
                            Console.Write("-hundred");
                        }
                        else if (lastDig == 0)
                        {
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            TwentyToNinetyDigitToString(middleDig);
                        }
                        else if (middleDig == 1)
                        {
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            ElevenToNineteenDigitToString(lastDig);
                        }
                        else if (middleDig == 0)
                        {
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            OneToNineToString(lastDig);
                        }
                        else
                        {
                            OneToNineToString(firstDig);
                            Console.Write("-hundred and ");
                            TwentyToNinetyDigitToString(middleDig);
                            Console.Write(" ");
                            OneToNineToString(lastDig);
                        }
                    }

                }
                Console.WriteLine();

            }
        }

        public static void OneToNineToString(int number)
        {
            switch (number)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;

            }


        }

        public static void ElevenToNineteenDigitToString(int number)
        {
            switch (number)
            {

                case 1: Console.Write("eleven"); break;
                case 2: Console.Write("twelve"); break;
                case 3: Console.Write("thirteen"); break;
                case 4: Console.Write("fourteen"); break;
                case 5: Console.Write("fifteen"); break;
                case 6: Console.Write("sixteen"); break;
                case 7: Console.Write("seventeen"); break;
                case 8: Console.Write("eighteen"); break;
                case 9: Console.Write("nineteen"); break;

            }
        }

        public static void TwentyToNinetyDigitToString(int number)
        {
            switch (number)
            {

                case 1: Console.Write("ten"); break;
                case 2: Console.Write("twenty"); break;
                case 3: Console.Write("thirty"); break;
                case 4: Console.Write("fouty"); break;
                case 5: Console.Write("fifty"); break;
                case 6: Console.Write("sixty"); break;
                case 7: Console.Write("seventy"); break;
                case 8: Console.Write("eighty"); break;
                case 9: Console.Write("ninety"); break;

            }
        }
    }
}
