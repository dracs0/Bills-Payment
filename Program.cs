namespace Bill_Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String username = "Renmar";
            String password = "Renmar123";

            Console.WriteLine("Bills Payment");

            Console.WriteLine("Enter your Name: ");
            string inputUsername = Console.ReadLine();

            Console.WriteLine("Enter your Password: ");
            string inputPassword = Console.ReadLine();
                        
            for (int i = 0; i < 2; i++)
            {
                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Login successful! Welcome, " + username);

                    Console.WriteLine("Enter an amount: ");
                    string inputAmount = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid username or password. please try again.");
                }
            }
        }
    }
}