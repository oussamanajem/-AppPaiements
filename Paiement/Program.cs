<<<<<<< HEAD
﻿NewMethod();

static void NewMethod()
{
    Console.WriteLine("Hello, World!");
=======
﻿using System;

namespace Paiement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of CreditCardPaiement with sample data
            Paiement creditPayment = new CreditCardPaiement(100.00m, DateTime.Now, "1234-5678-9012-3456");

            // Display the details of the payment
            creditPayment.DisplayDetails();

            Console.ReadLine(); // Keep the console window open to view the output
        }
    }
>>>>>>> ce3c406 (Initial commit with .gitignore)
}
