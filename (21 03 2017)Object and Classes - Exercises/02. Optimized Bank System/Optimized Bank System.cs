using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<BankAccount> result = new List<BankAccount>();


            while (input != "end")
            {
                var currInput = ReadInput(input);
                result.Add(currInput);

                input = Console.ReadLine();
            }


            var orderedResult = result.OrderByDescending(x => x.AccountBalance).ThenBy(x => x.Bank.Length).ToList();

            foreach (var element in orderedResult)
            {
                Console.WriteLine("{0} -> {1} ({2})", element.AccountName, element.AccountBalance, element.Bank);
            }
        }

        public static BankAccount ReadInput(string text)
        {
            var split = text.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new BankAccount
            {
                Bank = split[0],
                AccountName = split[1],
                AccountBalance = decimal.Parse(split[2])
            };
        }

    }
}
