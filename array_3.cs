using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class array_3
    {
            static void Main()
            {
            Console.WriteLine("24SOECE13033 - MAKWANA YASHVI");

            Console.Write("Enter the number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[n];

                Console.WriteLine($"Enter {n} values:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Enter value {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nArray in reverse order:");
                for (int i = n - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        
    }
}
