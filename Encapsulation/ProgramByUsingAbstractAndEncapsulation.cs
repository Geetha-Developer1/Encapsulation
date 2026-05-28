using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class BankAccount1
    {
        double balance;
        public BankAccount1(double balance)
        {
            this.balance = balance;
        }
        public double Balance
        {
            get { return balance; }
            set {
                if (value > 0)
                    balance = value;

            }
        }
        public abstract void AccountType();
       
    }
    class SavingAccount:BankAccount1
    {
        public double SAmount;
        public SavingAccount(double samount):base(100000)
        {
            this.SAmount = samount;
        }
        public  override void AccountType()
        {
            Console.WriteLine("This is under SavingAccount");
            if (SAmount > 0)
            {
                Balance += SAmount;
            }
            Console.WriteLine("Available Balance in SavingAccount:" + Balance+"\n");
        }
    }
    class CurrentAccount:BankAccount1
    {
        public double CAmount;
        public CurrentAccount(double camount):base(100000)
        {
            this.CAmount = camount;
        }
        public override void AccountType()
        {
            Console.WriteLine("This is under CurrentAccount");
            if(CAmount>0)
            {
                Balance += CAmount;
            }
            Console.WriteLine("Available Balance in CurrentAccount :" + Balance+"\n");
        }
    }
    internal class ProgramByUsingAbstractAndEncapsulation
    {
        static void Main(string[] args)
        {
            BankAccount1 b = new SavingAccount(30000);
            Console.WriteLine("Initial hoBalance:" + b.Balance);
            b.AccountType();
            b = new CurrentAccount(50000);
            b.AccountType();
           
        }
    }
}
