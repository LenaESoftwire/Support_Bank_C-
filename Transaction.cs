using System;

namespace Support_Bank_C_
{
    public class Transaction
    {
        public string Date {get; set;}
        public string To {get; set;}
        public string From {get; set;}
        public string Narrative {get; set;}
        public decimal Amount {get; set;}

        public Transaction(string[] columns)
        {
            Date = columns[0];
            From = columns[1];
            To = columns[2];
            Narrative = columns[3];
            Amount = Convert.ToDecimal(columns[4]);
        }
    }
}