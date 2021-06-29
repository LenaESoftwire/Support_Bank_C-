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
            Console.WriteLine(bank.Transactions[0].To + " " + bank.Transactions[0].Amount);
        }
    }
}
