using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>();

            var lastAdded = 0;

            var currInput = Console.ReadLine();

            var noElementsLeft = false;

            var lastRemoved = 0;
            while (currInput != "stop" || noElementsLeft)
            {
                if (currInput != "bang")
                {
                  
                    myList.Insert(0,int.Parse(currInput));
                    lastAdded = int.Parse(currInput);
                    
                }
                else
                {
                    if (myList.Count > 0 )
                    {
                        var smallerThanAvarage = (ElementWhoseValueIsSmallerThanTheAverageOfTheElementsOfTheList(myList));
                        myList.Remove(smallerThanAvarage);
                        lastRemoved = smallerThanAvarage;
                        Console.WriteLine($"shot {smallerThanAvarage}");
                        DecrementElementsInList(myList);

                    }
                    else
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        noElementsLeft = true;
                        break;
                        
                    }
                }

                currInput = Console.ReadLine();
            }

            if (currInput == "stop")
            {
                if (myList.Count == 0)
                {
                    Console.WriteLine($"you shot them all. last one was {lastRemoved}");
                }
                else
                {
                   
                    for (int i = 0; i < myList.Count; i++)
                    {
                        
                    }
                    Console.WriteLine($"survivors: {string.Join(" ",myList)}");
                }

            }
            
           

        }

        private static void DecrementElementsInList(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                myList[i]--;
            }
        }

        private static int ElementWhoseValueIsSmallerThanTheAverageOfTheElementsOfTheList(List<int> myList)
        {
            var sum = 0;
            var average = 0d;
            var smallerElement = 0;


            for (int i = 0; i < myList.Count; i++)
            {
                sum += (myList[i]);
            }

            average = sum / myList.Count;


            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i]<= average)
                {
                    
                    smallerElement = myList[i];
                    break;
                }
            }

            return smallerElement;
        }
    }
}
