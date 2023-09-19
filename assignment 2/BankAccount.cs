using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class BankAccount
    {
        int accountNumber; string accountHolderName; float balance; private float currentBalance;
        private void deposit()
        {
            Console.Write("Enter amount to deposit: ");
            balance=Convert.ToInt32(Console.ReadLine());
            currentBalance += balance;
            Console.WriteLine("Your updated balance is: "+currentBalance);
        }
        private void withdrawel() {
            Console.WriteLine("Enter amount to withdrawel: ");
            balance = Convert.ToInt32(Console.ReadLine());
            if (currentBalance > 500)
            {
                currentBalance -= balance;
                Console.WriteLine("Your updated balance is: " + currentBalance);
            }
            else
                Console.WriteLine("Sorry balance should be greater than 500 to withdrawel");
        }
        private void display() {
            Console.WriteLine("The account holder name is: "+accountHolderName);
            Console.WriteLine("The account number is: " + accountNumber);
            Console.WriteLine("Account balance is: " + currentBalance);
        }
        private void read(string accountHolderName,int accountNumber)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
        }
        /*static void Main(string[] args)
        {
            BankAccount obj2 = new BankAccount();
            obj2.read("Akash singh",123456789);
            obj2.deposit();
            obj2.withdrawel();
            obj2.display();
        }*/
    }
}
