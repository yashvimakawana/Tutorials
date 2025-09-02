using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q5
    {
        public class A // Base class
        {
            public A(int value)
            {
                // Executes some code in the constructor.
                Console.WriteLine("Base constructor A()");
            }
        }

        public class B : A // Derived class
        {
            public B(int value) : base(value)
            {
                // The base constructor is called first.
                // ... Then this code is executed.
                Console.WriteLine("Derived constructor B()");
            }
        }
        static void Main()
        {
            Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
            // Correct object creation syntax using 'new'
            A a = new A(0); // Calls base constructor
            B b = new B(1); // Calls base constructor first, then derived constructor
        }
    }
}