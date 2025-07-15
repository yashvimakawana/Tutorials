using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q19
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");
            int rows = 4; // Total number of rows in the pyramid

            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                // Print asterisks with a space
                for (int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
