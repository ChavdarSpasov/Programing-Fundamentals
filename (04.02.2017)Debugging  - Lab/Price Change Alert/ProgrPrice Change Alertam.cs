using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double thrshold = double.Parse(Console.ReadLine());

        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = DifferenceBetweenTwoPrices(firstPrice, nextPrice);
            bool significantDifference = IsDif(difference, thrshold);

            string message = Get(nextPrice, firstPrice, difference, significantDifference);
            Console.WriteLine(message);

            firstPrice = nextPrice;
        }
    }

    static string Get(double nextPrice, double firstPrice, double difference, bool etherTrueOrFalse)       
    {
        string output = "";
        if (difference == 0)
        {
            output = string.Format("NO CHANGE: {0}", nextPrice);
        }
        else if (!etherTrueOrFalse)
        {
            output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
            output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, difference);
        return output;
    }
    static bool IsDif(double difference, double thrshold)
    {
        if (Math.Abs(difference) >= thrshold)
        {
            return true;
        }
        return false;
    }

    static double DifferenceBetweenTwoPrices(double firstPrice, double nextPrice)
    {
        double r = (nextPrice - firstPrice) / firstPrice;
        return r * 100;
    }
}
