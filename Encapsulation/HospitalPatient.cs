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
        public Patient(string name, int age, string medicalhestory)
        {
            this.name = name;
            this.age = age;
            this.medicalhestory = medicalhestory;
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
            set
            {
                if (age > 0)
                    age = value;
            }
        }
        public string MedicalHistory
        {
            get { return medicalhestory; }
            set
            {
                if(medicalhestory !=null)
                    medicalhestory= value;
            }
        }
    }
    internal class HospitalPatient
    {
        static void Main(String[] args)
        {
            Patient p = new Patient("ABC", 35, "Something");
            Console.WriteLine("Name is :" + p.Name);
            Console.WriteLine("Age is :" + p.Age);
            Console.WriteLine("Medical Hestory is:" + p.MedicalHistory);
        }
    }
}
