using System;

namespace OPPS_Basics
{
  //Encapsulation Example
  //Example 1
   public class AccountInfo
    {
        private string accountNumber;
        private decimal balance;

        public AccountInfo(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
        }
       
    }
   class Program
    {
        static void Main(string[] args)
        {
            AccountInfo account = new AccountInfo("12345", 1000);
            account.Deposit(500);
            account.DisplayBalance();
            account.Withdraw(200);
            account.DisplayBalance();
           
        }
        
    }
}
