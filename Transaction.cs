using System;

namespace Support_Bank_C_
{
    public class Transaction
    {
        public DateTime Date;
        public string To;
        public string From;
        public string Narrative;
        public double Amount;

        public Transaction(string[] columns)
        {
            From = columns[1];
            To = columns[2];
            Narrative = columns[3];
            Amount = Convert.ToDouble(columns[4]);
        }
    }
}