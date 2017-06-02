using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerLevels = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var afterOneDay = new int[powerLevels.Length];

           
            var days = 0;
            var season = 0;
            var end = false;

            while (true)
            {
                for (int j = 0; j < powerLevels.Length; j++)
                {
                    var sum = 0;

                    for (int i = 0; i < powerLevels.Length; i++)
                    {
                        if (i != j)
                        {
                            powerLevels[i]--;
                        }                    

                    }

                    for (int i = 0; i < powerLevels.Length; i++)
                    {
                        if (powerLevels[i] <= 0)
                        {
                            afterOneDay[i] = 0;
                        }
                        else
                        {
                            afterOneDay[i] = powerLevels[i];
                        }
                       
                    }

                    
                    days++;

                    for (int i = 0; i < powerLevels.Length; i++)
                    {
                        powerLevels[i] = afterOneDay[i];
                    }

                    for (int i = 0; i < powerLevels.Length; i++)
                    {
                        sum += powerLevels[i]; 
                    }

                    if (sum ==0)
                    {
                        end = true;
                        break;
                        
                    }
                }

                if (end)
                {
                    break;
                }
                season++;

                for (int i = 0; i < powerLevels.Length; i++)
                {
                    if (powerLevels[i]>0)
                    {
                        powerLevels[i] += 1;
                    }
                }



            }

          Console.WriteLine($"survived {days} days ({season} seasons)");
                

        }
    }

}


