using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q10
    {
        class MyException : Exception
        {
            // Constructor accepting a message
            public MyException(string str) : base(str)
            {
            }
        }


        public static void Main()
        {
            Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");


            try
            {
                // Throw custom exception
                throw new MyException("my exception generated.");
            }
            catch (MyException e) // Catch specific exception
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            finally
            {
                // Always executed
                Console.WriteLine("LAST STATEMENT");
            }
        }
    }
}