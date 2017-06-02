using System;


namespace _07.Sales_Report
{
    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public string Hello()
        {
            return $"I am 1 {Age} years old Cat";
        }
    }
}
