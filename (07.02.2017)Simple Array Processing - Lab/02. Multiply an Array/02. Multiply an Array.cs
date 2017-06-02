using System;


public class Program
{
    public static void Main()
    {
        string lineOfNUmbers = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());

        string[] arrOfString = lineOfNUmbers.Split(' ');

        double[] arrOfInt = new double[arrOfString.Length];
        for (int i = 0; i < arrOfString.Length; i++)
        {
            arrOfInt[i] = double.Parse(arrOfString[i]);
        }

        ;

        for (int i = 0; i < arrOfString.Length; i++)
        {

            arrOfInt[i] = arrOfInt[i] * p;

            Console.Write(arrOfInt[i] + " ");
        }



    }
}