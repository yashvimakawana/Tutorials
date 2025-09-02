using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Method_overloding
    {
        static int Add(int a, int b)
       {
        return a + b;
        }

    static int Add(int a, int b, int c)
        {
        return a + b + c;
        }
    static double Add(double a, double b)
            { return a + b; }
        static double Add(int a, int b, double c)
            { return a + b + c; }

        public static void main (string[] args)
    }
}
