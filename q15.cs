using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q15
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI ");

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (!char.IsDigit(ch))
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }
            }

            long number = long.Parse(input);
            int digits = input.Length;
            long sumPower = 0;

            foreach (char ch in input)
            {
                int d = ch - '0';
                sumPower += (long)Math.Pow(d, digits);
            }

            if (sumPower == number)
                Console.WriteLine($"{number} is an Armstrong number.");
            else
                Console.WriteLine($"{number} is NOT an Armstrong number.");
        }
    }
}
