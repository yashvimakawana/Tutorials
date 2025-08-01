using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class array_9
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKWANA YASHVI");


            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Original array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nEnter the position of the element to delete (0-based index): ");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position >= 0 && position < numbers.Length)
            {
                int[] newArray = new int[numbers.Length - 1];

                for (int i = 0; i < position; i++)
                {
                    newArray[i] = numbers[i];
                }

                for (int i = position + 1; i < numbers.Length; i++)
                {
                    newArray[i - 1] = numbers[i];
                }

                Console.WriteLine("\nArray after deletion:");
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
        }
    }
}
