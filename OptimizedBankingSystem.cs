using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            List<BankAccount> output= new List<BankAccount>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var parts = input
                    .Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var bank = parts[0];
                var accountName = parts[1];
                var accountBalance = parts[2];
                
                BankAccount optimized = new BankAccount();
                {
                    optimized.Bank = bank;
                    optimized.Name = accountName;
                    optimized.Balance = decimal.Parse(accountBalance);                   
                }

                output.Add(optimized);

                input = Console.ReadLine();
            }

                 var newOutput = output                
                .OrderByDescending(x => x.Balance)                
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (BankAccount item in newOutput)
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }
    }

    public class BankAccount
    {
            public string Name { get; set; }

            public string Bank { get; set; }

            public decimal Balance { get; set; }        
    }
}
