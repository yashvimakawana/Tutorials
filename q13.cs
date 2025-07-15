using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q13
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI ");
            int n = 11;
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }


            Console.WriteLine();
        }

    }
}
