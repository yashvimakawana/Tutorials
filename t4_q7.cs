using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q7
    {
        sealed class A
        {
            public int x;
            public int y;
        }

        // Removed inheritance from sealed class
        // class B : A // ❌ This is not allowed if A is sealed
        // {
        //     public int z;
        // }

        static void Main()
        {
            Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
            A sc = new A(); // Creating object of sealed class
            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }

    }
}