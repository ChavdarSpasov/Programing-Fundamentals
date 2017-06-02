using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = ulong.Parse(Console.ReadLine());
            var numberTwo = ulong.Parse(Console.ReadLine());

            decimal max = Math.Max(numberOne, numberTwo);
            decimal min = Math.Min(numberOne, numberTwo);



            if (min <= byte.MaxValue)
            {
                if (max <= ushort.MaxValue && max > byte.MaxValue)
                {
                    Console.WriteLine("bigger type: ushort");
                    Console.WriteLine("smaller type: byte");
                    var overflow = Math.Round(max / byte.MaxValue);
                    Console.WriteLine("{0} can overflow byte {1} times", max, overflow);
                }

                else if (max <= uint.MaxValue && max > ushort.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: byte");
                    var overflow = Math.Round(max / byte.MaxValue);
                    Console.WriteLine("{0} can overflow byte {1} times", max, overflow);
                }

                else if (max <= ulong.MaxValue && max > uint.MaxValue)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: byte");
                    var overflow = Math.Round(max / byte.MaxValue);
                    Console.WriteLine("{0} can overflow byte {1} times", max, overflow);
                }

                else
                {
                    Console.WriteLine("bigger type: byte");
                    Console.WriteLine("smaller type: byte");
                    var overflow = Math.Round(max / byte.MaxValue);
                    Console.WriteLine("{0} can overflow byte {1} times", max, overflow);
                }

            }

            else if (min <= ushort.MaxValue)
            {
                if (max <= uint.MaxValue && max > ushort.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: ushort");
                    var overflow = Math.Round(max / ushort.MaxValue);
                    Console.WriteLine("{0} can overflow ushort {1} times", max, overflow);
                }

                else if (max <= ulong.MaxValue && max > uint.MaxValue)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: ushort");
                    var overflow = Math.Round(max / ushort.MaxValue);
                    Console.WriteLine("{0} can overflow ushort {1} times", max, overflow);
                }

                else
                {
                    Console.WriteLine("bigger type: ushort");
                    Console.WriteLine("smaller type: ushort");
                    var overflow = Math.Round(max / ushort.MaxValue);
                    Console.WriteLine("{0} can overflow ushort {1} times", max, overflow);
                }

            }

            else if (min <= uint.MaxValue)
            {

                if (max <= ulong.MaxValue | max > uint.MaxValue)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: uint");
                    var overflow = Math.Round(max / uint.MaxValue);
                    Console.WriteLine("{0} can overflow uint {1} times", max, overflow);
                }

                else
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: uint");
                    var overflow = Math.Round(max / uint.MaxValue);
                    Console.WriteLine("{0} can overflow uint {1} times", max, overflow);
                }

            }

            else
            {
                Console.WriteLine("bigger type: ulong");
                Console.WriteLine("smaller type: ulong");
                var overflow = Math.Round(max / ulong.MaxValue);
                Console.WriteLine("{0} can overflow ulong {1} times", max, overflow);

            }

        }
    }
}
