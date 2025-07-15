using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q21
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");
            // Input
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input number: ");
            int digit = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.WriteLine("\nThe series is:");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                Console.Write(term);

                if (i < n)
                    Console.Write(" + ");

                sum += term;
            }

            Console.WriteLine("\nThe Sum is : " + sum);
        }
    }
}
