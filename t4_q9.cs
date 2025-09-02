using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q9
    {
        public static void Main()
        {
            int x = 0;
            Console.WriteLine("24SOECE13032 - KINJAL KHIMSURIYA");

            try
            {
                int div = 100 / x;
                Console.WriteLine("Division result: " + div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed!");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}