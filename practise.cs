using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class practise
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num + 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0 || j == 2 || i == 0 || i == num)
                    {
                        Console.Write(num + " ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}

