using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var dataAsString = Console.ReadLine();

            var data = DateTime.ParseExact(dataAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(data.DayOfWeek);



        }
    }
}
