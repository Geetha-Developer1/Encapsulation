using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class Person
    {
       public string name {  get; set; }
        int age;
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
           get { return age; } 
            set { age = value; }
        }
        public void Display()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Age is: " + age);
        }
        public abstract void Role();
    }
    class Student : Person
    {
        int Rollno;
        public Student(int Rollno):base("Rama",18)
        {
            this.Rollno = Rollno;
        }
        public override void Role()
        {
            Console.WriteLine("Student");
        }
        protected void Study()
        {
            Console.WriteLine("10th Class,Roll No:" + Rollno);
        }
        public void StudentStudying()
        {
            Study();
        }
    }
    class Teacher : Person
    {
        string Subject;
        public Teacher(String Subject) : base("Sita", 30)
        {
            this.Subject = Subject;
        }
        public override void Role()
        {
            Console.WriteLine("Teacher");
        }
        public void Teach()
        {
            Console.WriteLine("Teaching " + Subject);
        }
    }

    internal class SMS
    {
        //static void Main(String[] args)
        //{
        //    Person p = new Student(1001);
        //    p.Role();
           
        //    ((Student)p).StudentStudying();
        //    p.Age = 19; 
        //    p = new Teacher("English");
        //    p.Role();
            
        //    ((Teacher)p).Teach();
        //}
    }
}
