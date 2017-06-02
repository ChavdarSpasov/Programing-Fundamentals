using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {

            var arrOfCordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var conditionX = arrOfCordinates[0];
            var conditionY = arrOfCordinates[1];

            for (int i = 0; i < arrOfCordinates.Length; i++)
            {
                arrOfCordinates[i] = 0;
            }

            var arrOfSequence = Console.ReadLine().Split(' ');

            for (int i = 0; i < arrOfSequence.Length ; i += 2)
            {
                if (arrOfSequence[i] == "up")
                {
                    arrOfCordinates[1] += double.Parse(arrOfSequence[i + 1]);
                }
                else if (arrOfSequence[i] == "down")
                {
                    arrOfCordinates[1] -= double.Parse(arrOfSequence[i + 1]);
                }
                else if (arrOfSequence[i] == "left")
                {
                    arrOfCordinates[0] -= double.Parse(arrOfSequence[i + 1]);
                }
                else if (arrOfSequence[i] == "right")
                {
                    arrOfCordinates[0] += double.Parse(arrOfSequence[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{arrOfCordinates[0]}, {arrOfCordinates[1]}]");


            if (arrOfCordinates[0] == conditionX && arrOfCordinates[1] == conditionY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
           

        }
    }
}
