using System;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueRunning = true;
            //Create references
            Bank_Account[] BA = new Bank_Account[2];

            //Create objects
            BA[0] = new Bank_Account("Adam", "Somewhere", 0, 0);
            BA[1] = new Bank_Account("Bill", "Nowhere", 1, 6000);
            BA[2] = new Bank_Account("Chip", "Here", 2, 200000);

            while(true)
            {
                Console.WriteLine("PLease input acount number to access: ");
                int Current_user = Convert.ToInt32(Console.ReadLine()); ;
                do
                {
                    ContinueRunning = MainMenu(Current_user);
                }
                while (ContinueRunning == true);
            }
        }

        static bool MainMenu(int AccountNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) View Balance");
            Console.WriteLine("2) Make a deposit");
            Console.WriteLine("3) Make a withdrawal");
            Console.WriteLine("Anything else to exit");
            switch (Console.ReadLine())
            {
                case "1":
                    BA[AccountNumber].displayBalance();
                    return true;
                case "2":
                    BA[AccountNumber].displayBalance();
                    Console.WriteLine("How much would you like to depoit(in pennies)?");
                    Console.WriteLine("Enter zero (0) to cancel.");
                    BA[AccountNumber].deposit(Console.ReadLine);
                    return true;
                case "3":
                    BA[AccountNumber].displayBalance();
                    Console.WriteLine("How much would you like to withdraw(in pennies)?");
                    Console.WriteLine("Enter zero (0) to cancel.");
                    BA[AccountNumber].withdraw(Console.ReadLine);
                    return true;
                default:
                    return false;
            }
        }
    }
}
