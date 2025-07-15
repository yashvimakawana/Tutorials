using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class q6
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str;
            Console.WriteLine("24SOECE13033 - MAKAWANA YASHVI");

            Console.Write("Enter Number 1: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            result = Sum(a, b, c);

            Console.WriteLine("Sum : " + result);

            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}
