namespace Bill_Payment
{
    internal class Program
    {
        static void Main(string[] args)
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

                    Console.WriteLine("Bill Type (Water/Electricity): ");
                    string billType = Console.ReadLine();

                    Console.WriteLine(billType + " bill of " + inputAmount + " paid successfully using " + paymentMethod + ". Thank you for your payment!");

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