using BPAppService;
using BPDataService;
using BPModels;
using System;

namespace Bill_Payment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PaymentService service = new PaymentService();

            while (true)
            {
                Console.WriteLine("\nBills Payment System");
                Console.WriteLine("1. Create Payment");
                Console.WriteLine("2. View Payments");
                Console.WriteLine("3. Update Payment");
                Console.WriteLine("4. Delete Payment");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Username: ");
                        string user = Console.ReadLine();
                        Console.Write("Enter Bank: ");
                        string bank = Console.ReadLine();
                        Console.Write("Enter Amount: ");
                        string amount = Console.ReadLine();
                        Console.Write("Enter Method (Credit/Debit): ");
                        string method = Console.ReadLine();
                        Console.Write("Enter Bill Type (Water/Electricity/Internet): ");
                        string billType = Console.ReadLine();

                        var payment = service.CreatePayment(user, bank, amount, method, billType);
                        Console.WriteLine("Payment created successfully!");
                        service.PrintReceipt(payment);
                        break;

                    case "2":
                        Console.WriteLine("\n--- Payment History ---");
                        service.ShowPayments();
                        break;

                    case "3":
                        Console.Write("Enter Payment ID to update: ");
                        Guid updateId = Guid.Parse(Console.ReadLine());
                        var updated = new Payment
                        {
                            Username = "UpdatedUser",
                            Bank = "UpdatedBank",
                            Amount = "999",
                            PaymentMethod = "Debit",
                            BillType = "Internet"
                        };
                        service.UpdatePayment(updateId, updated);
                        Console.WriteLine("Payment updated.");
                        break;

                    case "4":
                        Console.Write("Enter Payment ID to delete: ");
                        Guid deleteId = Guid.Parse(Console.ReadLine());
                        service.DeletePayment(deleteId);
                        Console.WriteLine("Payment deleted.");
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}