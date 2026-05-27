using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Patient
    {
        string name;
        int age;
        string medicalhestory;
        public Patient(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set
            {


                if (name !=null)
                    name = value;
            }
        }
        public int Age
        {
            get { return age; }
           
        }
        public string MedicalHistory
        {
            set
            {
                if(medicalhestory !=null)
                    medicalhestory= value;
            }
        }
        public bool IsEligibleforSurgery()
        {
            return age >= 18;
        }
    }
    internal class HospitalPatient
    {
        //static void Main(String[] args)
        //{
        //    Patient p = new Patient("ABC", 35);
        //    p.MedicalHistory = "Something";
        //    Console.WriteLine($"Name is {p.Name},Age is {p.Age}");
        //}
    }
}
