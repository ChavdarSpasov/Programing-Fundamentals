using System;
using System.Collections.Generic;
using System.Linq;

public class Dog
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int NumberOfLegs { get; set; }

    public string ProduseSound()
    {
        return ("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }
}
public class Cat
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int IntelligenceQuatient { get; set; }

    public void ProduseSound()
    {
        Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }
}
public class Snake
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int CrueltyCoefficient { get; set; }

    public void ProduseSound()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }
}



public class Program
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var dogs = new Dictionary<string, Dog>();
        var cats = new Dictionary<string, Cat>();
        var snakes = new Dictionary<string, Snake>();

        while (inputLine != "I'm your Huckleberry")
        {

            string[] inputParam = inputLine.Split();

            if (inputParam.Length > 2)
            {

                string type = inputParam[0];
                string name = inputParam[1];
                int age = int.Parse(inputParam[2]);
                int parameters = int.Parse(inputParam[3]);

                switch (type)
                {
                    case "Dog":
                        Dog newDog = new Dog();

                        newDog.Name = name;
                        newDog.Age = age;
                        newDog.NumberOfLegs = parameters;

                        dogs.Add(newDog.Name, newDog);
                        break;
                    case "Cat":
                        Cat newCat = new Cat();

                        newCat.Name = name;
                        newCat.Age = age;
                        newCat.IntelligenceQuatient = parameters;

                        cats.Add(newCat.Name, newCat);
                        break;
                    case "Snake":
                        Snake newSnake = new Snake();

                        newSnake.Name = name;
                        newSnake.Age = age;
                        newSnake.CrueltyCoefficient = parameters;

                        snakes.Add(newSnake.Name, newSnake);
                        break;

                }
            }
            else
            {
                var animalName = inputParam[1];

                if (dogs.ContainsKey(animalName))
                {
                    Console.WriteLine(dogs[animalName].ProduseSound());
                }
                else if (cats.ContainsKey(animalName))
                {
                    cats[animalName].ProduseSound();
                }
                else if (snakes.ContainsKey(animalName))
                {
                    snakes[animalName].ProduseSound();
                }
            }

            inputLine = Console.ReadLine();
        }



        PrintColection(dogs);
        PrintColection(cats);
        PrintColection(snakes);


    }

    public static void PrintColection(Dictionary<string, Dog> dog)
    {
        foreach (var element in dog.Values)
        {
            Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", element.Name, element.Age, element.NumberOfLegs);
        }
    }

    public static void PrintColection(Dictionary<string, Cat> cat)
    {
        foreach (var element in cat.Values)
        {
            Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", element.Name, element.Age, element.IntelligenceQuatient);
        }
    }

    public static void PrintColection(Dictionary<string, Snake> snake)
    {
        foreach (var element in snake.Values)
        {
            Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", element.Name, element.Age, element.CrueltyCoefficient);
        }
    }
}