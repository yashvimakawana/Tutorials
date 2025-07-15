using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q11
    {
        public static void Main()
        {
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (gender == 'M')
                Console.WriteLine("Mr. " + name);
            else if (gender == 'F')
                Console.WriteLine("Ms. " + name);
            else
                Console.WriteLine("Invalid gender input.");
        }
    }
}
