using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    class Bank_Account
    {
        // Create values
        private string FullName, Address;
        private int BalancePennies, AccountNumber;
        private static int AccountsCreated = 0;

        // Set up
        public Bank_Account(string name, string address, int pennies)
        {
            FullName = name;
            FullName = address;
            BalancePennies = pennies;
            AccountNumber = AccountsCreated;
            AccountsCreated++;
        }


        public Bank_Account()
        {
            FullName = "";
            FullName = "";
            AccountNumber = 0;
            BalancePennies = 0;
            AccountNumber = AccountsCreated;
            AccountsCreated++;
        }

        
        // Get/set balance
        private void setBalance(int n)
        {
            BalancePennies = n;
        }
        public int getBalance()
        {
            return BalancePennies;
        }


        // print balance
        public void displayBalance()
        {
            Console.WriteLine("Your balance is: £" + Convert.ToString(getBalance() / 100));
        }


        // Make withdrawal and deposit
        public void withdraw(int monies)
        {
            setBalance(getBalance()-monies);
            Console.WriteLine("You have withdrawn: £" + Convert.ToString(monies / 100));
            displayBalance();
        }

        public void deposit(int monies)
        {
            setBalance(getBalance() + monies);
            Console.WriteLine("You have withdrawn: £" + Convert.ToString(monies / 100));
            displayBalance();
        }
    }
}
