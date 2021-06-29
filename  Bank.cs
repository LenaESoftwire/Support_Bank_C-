using System.Collections.Generic;

namespace Support_Bank_C_
{
    public class Bank
    {
        public List<Transaction> Transactions { get; set; }
        public List<UserAccount> Users { get; set; }

        public Bank() 
    {
        Transactions = new List<Transaction>();
        Users = new List<UserAccount>(); 
    }
    }

    
}