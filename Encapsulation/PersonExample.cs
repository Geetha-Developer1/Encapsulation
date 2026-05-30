using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class School
    {
        public string Schoolname {  get; set; }
       
        public School(string Schoolname)
        {
            this.Schoolname = Schoolname;
           
        }
        public void Display()
        {
            Console.WriteLine($"School Name is:{Schoolname}");
        }
        public abstract void Branch();
    }
    abstract class Person3 : School
    {
        string branch;
        string pname;
       
        public Person3(string pname,string Schoolname, string branch):base(Schoolname)
        {
            this.pname = pname;
            this.branch = branch;
        }
        public override void Branch()
        {
            Console.WriteLine($"Branch Name:{branch}");
        }
        public abstract void Role();


    }
    class students:Person3
    {
        int rollno;
        public students(string pname, string Schoolname, string branch,int rollno):base(pname, Schoolname, branch)
        {
            this.rollno = rollno;
        }
        public override void Role()
        {
            Console.WriteLine($"I am a Student,Rollno :{rollno}");

        }
    }
    internal class PersonExample
    {
        static void Main(string[] args)
        {
            students s = new students("Rama", "ABC School", "Ameerpet", 1001);
            s.Display();
            s.Branch();
            s.Role();
        }
            
    }
}
