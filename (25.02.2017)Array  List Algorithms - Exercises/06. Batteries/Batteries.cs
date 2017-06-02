using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double[] usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int hoursOfStressTest = int.Parse(Console.ReadLine());

            var resultCapacities = new List<double>();
            var relultTest = new List<bool>();
            
           
            for (int i = 0; i < capacities.Length; i++)
            {
                var currCapsity = capacities[i];
                var currHour = hoursOfStressTest;

                while (currHour != 0)
                {

                    currCapsity -= usagePerHour[i];
                    currHour--;

                    if (currCapsity <= 0 )
                    {

                        resultCapacities.Add(currHour);
                        relultTest.Add(true);
                        break;

                    }

                   
                }
                if (currCapsity < 0)
                {
                    continue;
                }
                else
                {
                    resultCapacities.Add(currCapsity);
                    relultTest.Add(false);
                }
                


            }


            for (int i = 0; i < relultTest.Count; i++)
            {
                if (relultTest[i] == true)
                {
                    var bateriNumber = i + 1;
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", bateriNumber, hoursOfStressTest - resultCapacities[i]);
                }
                else
                {
                    var bateriNumber = i + 1;
                    var percent = (resultCapacities[i] * 100.0) / capacities[i];
                   Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", bateriNumber, Math.Round(resultCapacities[i],2),Math.Round(percent,2));
                }
            }

 
        }
    }
}
