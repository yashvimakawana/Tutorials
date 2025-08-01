using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class array_7
    {
            static void Main()
            {
            Console.WriteLine("24SOECE13033 - MAKWANA YASHVI");


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                int oddCount = 0, evenCount = 0;

                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                        evenCount++; 
                    else
                        oddCount++; 
                }

                int[] oddNumbers = new int[oddCount];
                int[] evenNumbers = new int[evenCount];

                int oddIndex = 0, evenIndex = 0;
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                        evenNumbers[evenIndex++] = num; 
                    else
                        oddNumbers[oddIndex++] = num; 
                }

                Console.WriteLine("Odd numbers:");
                foreach (int num in oddNumbers)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine("\nEven numbers:");
                foreach (int num in evenNumbers)
                {
                    Console.Write(num + " ");
                }
            }
    }
}
