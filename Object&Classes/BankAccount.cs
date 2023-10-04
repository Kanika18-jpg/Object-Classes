using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Classes
{
    internal class BankAccount
    {
        public double AccountNumber;
        public string AccountHolder;
        public double balance;
        public double deposited;
        public double withdrew;

        public BankAccount(double AccountNumber, string AccountHolder,  double balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.balance = balance;
        }

        public void deposit( double deposited)
        {
            balance += deposited;
            //Console.WriteLine("Balance after deposit : " + balance);
        }
        public void withdraw( double withdrew)
        {
            balance -= withdrew;
            //Console.WriteLine("Balance after withdrawl : " + balance);
        }
        public void display()
        {
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + balance);

        }
    }
    class Program2 {
        public static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount(11111, "Rakesh", 50000);
            BankAccount b2 = new BankAccount(11112, "Kanika", 50000);
            b1.deposit(2000);
            b2.withdraw(2000);

            b1.display();
            b2.display();

            Console.ReadLine();
        }
    }

}
