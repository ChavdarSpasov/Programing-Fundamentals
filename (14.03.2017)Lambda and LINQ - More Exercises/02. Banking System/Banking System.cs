using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankInfo = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputParam = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var bankName = inputParam[0];
                var bankAccountName = inputParam[1];
                var bankAccountBalance = decimal.Parse(inputParam[2]);

                if(!bankInfo.ContainsKey(bankName))
                {
                    bankInfo[bankName] = new Dictionary<string, decimal>();
                }

                if (!bankInfo[bankName].ContainsKey(bankAccountName))
                {
                    bankInfo[bankName][bankAccountName] = 0;
                }

                bankInfo[bankName][bankAccountName] += bankAccountBalance;

                input = Console.ReadLine();
            }


            bankInfo
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account
                => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})", account.Key, account.Value,bank.Key)));


            
            


         
        }
    
    }
}
