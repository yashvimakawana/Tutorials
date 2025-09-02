using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q8
    {
        class X
        {
            // Changed to public so Main() can access them
            public virtual void F() { Console.WriteLine("X.F"); }
            public virtual void F2() { Console.WriteLine("X.F2"); }
        }

        class Y : X
        {
            // Sealed override means this method cannot be overridden in Z
            public sealed override void F() { Console.WriteLine("Y.F"); }
            public override void F2() { Console.WriteLine("Y.F2"); }
        }

        class Z : Y
        {
            // Cannot override F() because it's sealed in Y
            // protected override void F() { Console.WriteLine("Z.F"); } // ❌ Removed

            public override void F2() { Console.WriteLine("Z.F2"); }
        }

        static void Main()
        {
            Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");

            X Obj1 = new X();
            Obj1.F();
            Obj1.F2();

            Y Obj2 = new Y();
            Obj2.F();
            Obj2.F2();

            Z Obj3 = new Z();
            Obj3.F();    // Calls sealed version from Y
            Obj3.F2();   // Calls overridden version from Z
        }

    }
}