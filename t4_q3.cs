using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class t4_q3
    {
        class Person
        {
            private string aadhaarNumber;

            protected int age;

            public string name;

            public Person(string name, int age, string aadhaarNumber)
            {
                this.name = name;
                this.age = age;
                this.aadhaarNumber = aadhaarNumber;
            }

            public void ShowPersonDetails()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);

                Console.WriteLine("Aadhaar: " + aadhaarNumber);
            }


            public void UpdateAge(int newAge)
            {
                age = newAge;
            }
        }

        class Employee : Person
        {
            private double salary;

            protected string department;

            public string designation;

            public Employee(string name, int age, string aadhaarNumber, string designation, string department, double salary)
                : base(name, age, aadhaarNumber)
            {
                this.designation = designation;
                this.department = department;
                this.salary = salary;
            }

            public void ShowEmployeeDetails()
            {
                Console.WriteLine("\n--- Employee Details ---");

                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Designation: " + designation);
                Console.WriteLine("Department: " + department);

                Console.WriteLine("Salary: " + salary);
            }


            public void UpdateSalary(double newSalary)
            {
                salary = newSalary;
            }
        }

        static void Main()
        {
            Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
            Employee emp1 = new Employee("John Doe", 30, "XXXX-YYYY-1111", "Manager", "HR", 55000);
            Employee emp2 = new Employee("Jane Smith", 28, "XXXX-YYYY-2222", "Developer", "IT", 45000);

            emp1.ShowEmployeeDetails();
            emp2.ShowEmployeeDetails();

            emp1.UpdateAge(31);
            emp2.UpdateSalary(48000);

            Console.WriteLine("\nAfter updates:");
            emp1.ShowEmployeeDetails();
            emp2.ShowEmployeeDetails();
        }

    }
}