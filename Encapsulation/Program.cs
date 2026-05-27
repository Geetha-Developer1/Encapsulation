using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account
    {
        private double balance;
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
        }
        public double Getbalance()
        {
            return balance;
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Account a = new Account();
        //    Console.WriteLine("Enter Amount to Deposit:");
        //    double amt = double.Parse(Console.ReadLine());
        //    a.Deposit(amt);
        //    Console.WriteLine("Your Current Balance:" + a.Getbalance());
        //    Console.WriteLine("Enter Amount to Withdraw:");
        //    double amttowd = double.Parse(Console.ReadLine());
        //    a.Withdraw(amttowd);
        //    //double ab=a.Getbalance();
        //    //Console.WriteLine("Available Balance:" + ab);
        //    Console.WriteLine("Availabale Balance: " + a.Getbalance());
        //}
    }
}
