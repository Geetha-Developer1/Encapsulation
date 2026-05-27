using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class BankAccount
    {
        double balance;
        string pin;
        public double Balance
        {
            get { return balance; }
            set { 
                if(value>0)
                 balance = value;
                }
        }
        public void Deposite(double amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void Withdraw(double amount,string enterpin)
        {
            if (enterpin == pin && amount <= balance)
                balance -= amount;
        }
        public BankAccount(double balance,string pin)
        {
            this.balance = balance;
            this.pin = pin;
        }
    }
    internal class newmodel
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(10000, "1234");
            ba.Deposite(5000);
            ba.Withdraw(6000, "1234");
            ba.Withdraw(2000,"3333");
            Console.WriteLine("Available Balance:" + ba.Balance);

        }
    }
}
