using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q6
    {
        abstract class Test
        {
            // Protected field so derived classes can access it
            protected int a;

            // Abstract method must be public/protected and must be overridden in derived classes
            public abstract void A();
        }

        // Derived class 1
        class Example1 : Test
        {
            public override void A()
            {
                Console.WriteLine("Example1.A");
                a++; // Accessing protected member
                Console.WriteLine("Value of a after increment: " + a);
            }
        }

        // Derived class 2
        class Example2 : Test
        {
            public override void A()
            {
                Console.WriteLine("Example2.A");
                a--; // Accessing protected member
                Console.WriteLine("Value of a after decrement: " + a);
            }
        }

        static void Main()
        {
            Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
            // Reference Example1 through Test type
            Test test1 = new Example1();
            test1.A();

            // Reference Example2 through Test type
            Test test2 = new Example2();
            test2.A();
        }
    }
}