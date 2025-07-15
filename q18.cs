using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q18
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");
            int rows = 4; // Number of rows
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
