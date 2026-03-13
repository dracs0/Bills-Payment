using System;
using BillPaymentModels;
using BillPaymentAppService;

namespace Bill_Payment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Bills Payment");

                Console.WriteLine("Enter your Name: ");
                string inputUsername = Console.ReadLine();

                Console.WriteLine("Enter your Password: "); 
                string inputPassword = Console.ReadLine();

                if (inputUsername == "Renmar" && inputPassword == "Renmar123")
                {
                    Console.WriteLine("Login successful! Welcome, " + inputUsername + " !");

                    Console.WriteLine("Enter Bank Transact (BDO/BPI): ");
                    string bank = Console.ReadLine();

                    Console.WriteLine("Enter Payment Amount: ");
                    string inputAmount = Console.ReadLine();

                    Console.WriteLine("Payment Method (Credit/Debit): ");
                    string paymentMethod = Console.ReadLine();

                    Console.WriteLine("Bill Type (Water/Electricity/Internet): ");
                    string billType = Console.ReadLine();

                    Models payment = new Models
                    {
                        PaymentId = Guid.NewGuid(),
                        Username = inputUsername,
                        Bank = bank,
                        Amount = inputAmount,
                        PaymentMethod = paymentMethod,
                        BillType = billType
                    };

                    Console.WriteLine(payment.BillType + " bill of " + payment.Amount + " paid successfully using " + payment.PaymentMethod + " through " + payment.Bank + ". Thank you for your payment!");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                }
            }
        }
    }
}