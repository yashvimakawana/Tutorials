using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q5
    {
        static void Main(string[] args) // Main method: Entry point of the program
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");

            int n, fact = 1; // Declaring integer variables 'n' (input number) and 'fact' (to store factorial), initializing 'fact' to 1

            Console.WriteLine("Enter Number : "); // Prompting the user to enter a number

            string str = Console.ReadLine(); // Reading user input as a string

            n = Convert.ToInt32(str); // Converting the string input to integer and storing it in 'n'

            for (int i = 1; i <= n; i++) // Looping from 1 to n to calculate factorial
            {
                fact = fact * i; // Multiplying 'fact' by current loop value 'i'
            }
            Console.WriteLine("Factorial : {0}", fact); // Displaying the calculated factorial
            Console.Read(); // Waiting for user to press a key (to keep console window open)
        }
    }
}

