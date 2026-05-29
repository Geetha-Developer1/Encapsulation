using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class Person1
    {
        protected string name;
        private int age;
        public Person1(string name,int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Person1 Constructor is Calling");
        }
        public int  Age
        {
            get { return age; } 
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {name}, Age : {age}");
        }
        public abstract void Role();
    }
    class Student1:Person1
    {
        int rollno;
        public Student1(string name, int age, int rollno):base(name,age)
        {
            this.rollno = rollno;
            Console.WriteLine("Student1 Constructor is Calling");
        }
       
        public override void Role()
        {
            Console.WriteLine("I am a Student");
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {Age},RollNo: {rollno}");
        }
    }
    class Teacher1 : Person1
    {
        string subject;
        public Teacher1(string name,int age,string subject):base(name,age)
        {
            this.subject = subject;
            Console.WriteLine("Teacher1 constructor is calling");
        }
        

        public override void Role()
        {
            Console.WriteLine("I am a Teacher");
        }
        public void TeacherInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {Age},Subject: {subject}");
        }
    }
    internal class Example
    {
        //static void Main(string[] args)
        //{
        //    Person1 p = new Student1("ABC", 21, 1001);
        //    p.DisplayInfo();
        //    p.Role();
        //    ((Student1)p).StudentInfo();
        //    p = new Teacher1("XYZ", 30, "Computers");
        //    p.Role();
        //    ((Teacher1)p).TeacherInfo();

        //    //Student1 s = new Student1("A",20,1001);
        //    //s.DisplayInfo();
        //    //s.StudentInfo();
        //    //s.Role();

        //}
    }
}
