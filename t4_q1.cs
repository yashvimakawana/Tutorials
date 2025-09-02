using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q1
    {
        class Employee
        {
            private int empCode;
            private string name;
            private string designation;
            private double basicPay;

            // Constructor to initialize employee details
            public Employee(int empCode, string name, string designation, double basicPay)
            {
                this.empCode = empCode;
                this.name = name;
                this.designation = designation;
                this.basicPay = basicPay;
            }

            // Method to calculate HRA, DA and Total Pay
            public void CalculateAndPrintSalary()
            {
                double hra = 0.10 * basicPay;  // 10% of Basic Pay
                double da = 0.45 * basicPay;   // 45% of Basic Pay
                double totalPay = basicPay + hra + da;

                Console.WriteLine("Employee Code: " + empCode);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Designation: " + designation);
                Console.WriteLine("Basic Pay: " + basicPay);
                Console.WriteLine("HRA (10%): " + hra);
                Console.WriteLine("DA (45%): " + da);
                Console.WriteLine("Total Pay: " + totalPay);
                Console.WriteLine("-------------------------------------");
            }
        }

        // Main class
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
                // Create three employee objects
                Employee emp1 = new Employee(101, "John Doe", "Manager", 50000);
                Employee emp2 = new Employee(102, "Jane Smith", "Developer", 40000);
                Employee emp3 = new Employee(103, "David Lee", "Clerk", 25000);

                // Calculate and display salary details for each employee
                emp1.CalculateAndPrintSalary();
                emp2.CalculateAndPrintSalary();
                emp3.CalculateAndPrintSalary();

                Console.ReadLine();
            }
        }
    }
}