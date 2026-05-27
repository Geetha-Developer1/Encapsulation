using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account1
    {
        private double balance;
        private int pin=3333;
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount Deposited Successfully\n");
            }
            }
        public void Withdraw(double amount)
        {
            Console.WriteLine("Enter Your PIN number:");
            int pin1 = int.Parse(Console.ReadLine());
            if (pin1 == pin)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Amount Withdrawn Successfully\n");
                }
                else
                    Console.WriteLine(amount + " not Available in your Account");
            }
            else
                Console.WriteLine("PIN is Not Valid, Please Provide Valid PIN");
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    internal class WithdrawAmountwithPin
    {
        static void Main(string[] args)
        {
            Account1 a1 = new Account1();
            Console.WriteLine("Enter Amount to Deposit:");
            double amt=double.Parse(Console.ReadLine());
            a1.Deposit(amt);
            Console.WriteLine("Your Current Balance is:" + a1.GetBalance()+"\n");
            Console.WriteLine("Enter Amount to Withdraw:");
            double wdamt = double.Parse(Console.ReadLine());
            a1.Withdraw(wdamt);
            Console.WriteLine("Available Balance:"+a1.GetBalance());



        }
    }
}
