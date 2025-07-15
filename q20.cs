using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q20
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13034 - MANDHAT ALNUR");

            int rows = 4; // Total number of rows in the pyramid
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }

                // Print numbers with a space
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
