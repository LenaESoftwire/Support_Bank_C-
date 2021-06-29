namespace Support_Bank_C_
{
    public class UserAccount
    {
        public string Name {get; set;}
        public decimal Debt {get; set;}
        public decimal Lend {get; set;}

        public void CountDebtLend(Bank bank)
        {
            foreach (var transaction in bank.Transactions)
            {
               
                if (Name == transaction.To) {
                     Debt += transaction.Amount;
                }

                if (Name == transaction.From) {
                     Lend += transaction.Amount;
                }
            }
        }

        public UserAccount (string name)
        {
            Name = name;
        }
    }
}