using System.Transactions;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace Support_Bank_C_
{
    class Program
    {
        static void Main()
        {
            var bank = new Bank();
            var path = "./Data/Transactions2014.csv";
            var lines = File.ReadAllLines(path);
            lines = lines.Skip(1).ToArray();
            bank.Transactions = lines.Select(line => new Transaction(line.Split(','))).ToList();

            // Console.WriteLine(bank.Transactions[0].Date + " " + bank.Transactions[0].Amount);
            var userNames = new List<string>();
            foreach (var transaction in bank.Transactions)
            {
                if (!userNames.Contains(transaction.To))
                {
                    userNames.Add(transaction.To);
                }

                if (!userNames.Contains(transaction.From))
                {
                    userNames.Add(transaction.From);
                }
            }

            foreach (var username in userNames)
            {
                var user = new UserAccount(username);
                bank.Users.Add(user);
                user.CountDebtLend(bank);
                Console.WriteLine(user.Name + " debt " + user.Debt + " lend " + user.Lend);
            }
        }
    }
}
