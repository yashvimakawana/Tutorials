using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q22
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");
            int n = 5;
            for (int i = 1; i <= n; i++)
            {

                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= 2 * i - 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
