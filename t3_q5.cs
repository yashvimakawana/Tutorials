using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q5
    {
        class Product
        {
            // Data members
            private string pcode;
            private string pname;
            private string mname;

            // Constructor
            public Product(string pcd, string pnm, string mnm)
            {
                pcode = pcd;
                pname = pnm;
                mname = mnm;
            }

            // Display method
            public void Display()
            {
                Console.WriteLine("\nProduct Code:= " + pcode);
                Console.WriteLine("Product Name:= " + pname);
                Console.WriteLine("Manufacturer Name:= " + mname);
            }
        }

        public class TestProduct
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");

                // Take input from user
                Console.Write("Enter Product Code: ");
                string pcd = Console.ReadLine();

                Console.Write("Enter Product Name: ");
                string pnm = Console.ReadLine();

                Console.Write("Enter Manufacturer Name: ");
                string mnm = Console.ReadLine();

                // Create Product object
                Product p = new Product(pcd, pnm, mnm);

                // Call display method
                p.Display();

                Console.ReadLine(); // pause before exit
            }
        }
    }
}
