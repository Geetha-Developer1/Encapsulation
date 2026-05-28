using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class myclass
    {
        public void display()
        {
            Console.WriteLine("Display is calling");
        }
        public virtual void show()
        {
            Console.WriteLine("Show is calling");
        }
    }
    class dc : myclass
    {
        public void message()
        {
            Console.WriteLine("Message is calling");
        }
        public override void show()
        {
            Console.WriteLine("Override show is calling");
        }
    }
    class newdc:myclass
    {
        public override void show()
        {
            Console.WriteLine("New Override show is calling");
        }
    }
    internal class VirstualMethod
    {
       //static void Main(string[] args)
       //{
       //     myclass m = new myclass();
       //     m.show();
       //     dc objdc = new dc();
       //     objdc.display();
       //     objdc.show();
       //     objdc.message();
       //     newdc ndc = new newdc();
       //     ndc.show();
       //}
    }
}
