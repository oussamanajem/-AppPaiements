using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Paiement
{
    public class CreditCardPaiement : Paiement
    {
        // Property specific to CreditCardPaiement
        public string CardNumber { get; set; }

        // Constructor
        public CreditCardPaiement(decimal amount, DateTime date, string cardNumber)
        {
            Amount = amount;
            Date = date;
            CardNumber = cardNumber;
        }

        // Override the abstract method DisplayDetails
        public override void DisplayDetails()
        {
            Console.WriteLine($"Amount: {Amount}, Date: {Date.ToShortDateString()}, Card Number: {CardNumber}");
        }
    }
}
