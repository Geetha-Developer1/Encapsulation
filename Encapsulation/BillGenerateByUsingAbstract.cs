using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class HMWBS
    {
        public void BillDetails()
        {
            Console.WriteLine("HMWBS Bill is Generated");
        }
       public abstract void GetBill(double unit);
    }
    class ResidentialCustomer : HMWBS
    {
        public override void GetBill(double unit)
        {
            double bill = unit * 7;
            Console.WriteLine("Residencial Customer Bill:" + bill);
        }
    }
    class CommercialCustomer : HMWBS
    {
        public override void GetBill(double unit)
        {
                double bill=unit * 10;
            Console.WriteLine("Commercial Customer Bill:" + bill);
        }
    }
    class IndustryCustomers : HMWBS
    {
        public override void GetBill(double unit)
        {
            double bill = unit * 15;
            Console.WriteLine("Industry Customer Bill:" + bill);
        }
    }
    class AgriculturCustomer : HMWBS
    {
        public override void GetBill(double unit)
        {
            double bill = unit * 0;
            Console.WriteLine("Agricultur Customer Bill:" + bill);
        }
    }
    internal class BillGenerateByUsingAbstract
    {
        //static void Main(string[] args)
        //{
        //    HMWBS obj = new ResidentialCustomer();
        //    obj.BillDetails();
        //    Console.WriteLine("Enter Consumed Units:");
        //    double units=double.Parse(Console.ReadLine());
        //    obj.GetBill(units);

        //    obj = new CommercialCustomer();
        //    obj.GetBill(units);

        //    obj = new IndustryCustomers();
        //    obj.GetBill(units);

        //    obj=new AgriculturCustomer();
        //    obj.GetBill(units);  


        //}
    }
}
