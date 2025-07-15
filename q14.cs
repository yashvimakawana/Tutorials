using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q14
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI ");
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();   // read the whole number as text

            foreach (char ch in number)          // look at each character
            {
                switch (ch)                      // pick the matching word
                {
                    case '0': Console.Write("Zero "); break;
                    case '1': Console.Write("One "); break;
                    case '2': Console.Write("Two "); break;
                    case '3': Console.Write("Three "); break;
                    case '4': Console.Write("Four "); break;
                    case '5': Console.Write("Five "); break;
                    case '6': Console.Write("Six "); break;
                    case '7': Console.Write("Seven "); break;
                    case '8': Console.Write("Eight "); break;
                    case '9': Console.Write("Nine "); break;
                    default:                           // if the input isn’t a digit
                        Console.WriteLine("\nInvalid input.");
                        return;
                }
            }

            Console.WriteLine();  // move to a new line after printing all words
        }
    }
}
