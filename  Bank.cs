using System.Collections.Generic;
using System;

namespace Support_Bank_C_
{
    public class Bank
    {
        public List<Transaction> Transactions { get; set; }
        public List<UserAccount> Users { get; set; }

        public void ListAll()
        {
            foreach (var user in Users)
            {
                Console.WriteLine(user.Name + " debt " + user.Debt + " lend " + user.Lend);
            }
        }

        public void ListAccount(string username)
        {
            foreach (var transaction in Transactions)
            {
                if (username == transaction.To || username == transaction.From)
                {
                    transaction.PrintTransaction();
                }
            }
        }

        public Bank()
        {
            Transactions = new List<Transaction>();
            Users = new List<UserAccount>();
        }
    }
}