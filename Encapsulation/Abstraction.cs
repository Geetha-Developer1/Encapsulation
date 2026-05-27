using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class Abstractclass
    {
        public void start()
        {
            Console.WriteLine("Started The Class");
        }
        public void Resume()
        {
            Console.WriteLine("Resumed the class");
        }
        public void Display()
        {
            Console.WriteLine("Welcome");
        }
        public abstract void End();
    }
    class DerivedClass:Abstractclass
    {
        public override void End()
        {
            
            {
                Console.WriteLine("Sessiojn has End");
            }
        }
    }
    internal class Abstraction
    {
       static void Main(string[] args)
        {
            Abstractclass d=new DerivedClass();
            d.End();
            d.start();
            d.Resume();
            d.Display();
        }
    }
}
