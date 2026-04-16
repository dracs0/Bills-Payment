using BPAppService;
using BPDataService;
using BPModels;
using System;
using System.Reflection;

namespace Bill_Payment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PaymentService service = new PaymentService();
            PaymentDataService dataService = new PaymentDataService();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Bills Payment");

                Console.Write("Enter your Name: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Enter your Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == "Renmar" && inputPassword == "Renmar123")
                {
                    Console.WriteLine("Login successful! Welcome, " + inputUsername + "!");

                    Console.Write("Enter Bank Transact (BDO/BPI): ");
                    string bank = Console.ReadLine();

                    Console.Write("Enter Payment Amount: ");
                    string inputAmount = Console.ReadLine();

                    Console.Write("Payment Method (Credit/Debit): ");
                    string paymentMethod = Console.ReadLine();

                    Console.Write("Bill Type (Water/Electricity/Internet): ");
                    string billType = Console.ReadLine();

                    // Create payment using service
                    Models payment = service.CreatePayment(inputUsername, bank, inputAmount, paymentMethod, billType);

                    // Save payment in data service
                    dataService.SavePayment(payment);

                    // Print receipt
                    service.PrintReceipt(payment);

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                }
            }

            Console.WriteLine("\n--- Payment History ---");
            foreach (var p in dataService.GetPayments())
            {
                Console.WriteLine($"{p.BillType} - {p.Amount} via {p.Bank}");
            }
        }
    }
}