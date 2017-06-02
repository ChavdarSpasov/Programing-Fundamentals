using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new List<Exercise>();

            while (input!= "go go go")
            {
                var currInput = ReadInput(input);
                result.Add(currInput);

                input = Console.ReadLine();
            }
       
            foreach (var item in result)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}.");
                var number = 1;
                foreach (var element in item.Problems )
                {
                    Console.WriteLine("{0}. {1}",number,element);
                    number++;
                }
                
            }

        }

        public static Exercise ReadInput(string text)
        {
            var splittedText = text.Split(new char[] { ' ', '-', '>',',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new Exercise
            {
                Topic = splittedText[0],
                CourseName = splittedText[1],
                JudgeContestLink = splittedText[2],
                Problems = splittedText.Skip(3).ToList()
                


            };             
        }
    }
}
