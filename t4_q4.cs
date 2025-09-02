using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q4
    {
        class StaticVar
        {
            public static int num; // Static variable (shared by all objects)

            // Constructor - automatically called when object is created
            public StaticVar()
            {
                num = 0; // Initialize static variable only once if needed
            }

            // Method to increment the static variable
            public void count()
            {
                num++;
            }

            // Missing statement - a static method to return the value of num
            public static int getNum()
            {
                return num;
            }
        }

        class StaticTester
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
                StaticVar s = new StaticVar(); // Object creation

                // Incrementing the static variable using object method
                s.count();
                s.count();
                s.count();

                // Accessing static method directly using class name
                Console.WriteLine("Variable num: {0}", StaticVar.getNum());

                Console.ReadKey();
            }
        }
    }
}