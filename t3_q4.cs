using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q4
    {
        class Student
        {
            // Private data members
            private int rollNumber;
            private string name;
            private int age;

            // Public properties to access private members
            public int RollNumber
            {
                get { return rollNumber; }
                set { rollNumber = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                        age = value;
                    else
                        Console.WriteLine("Age must be positive!");
                }
            }

            // No-argument constructor
            public Student()
            {
                rollNumber = 0;
                name = "Unknown";
                age = 18;
            }

            // Parameterized constructor
            public Student(int r, string n, int a)
            {
                rollNumber = r;
                name = n;
                Age = a; // Use property to validate
            }

            // Method to display student details
            public void DisplayStudent()
            {
                Console.WriteLine("Student Details:");
                Console.WriteLine("Roll Number: " + rollNumber);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("-----------------------");
            }
        }

        // Test class to demonstrate Student objects
        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");

                // Creating 5 student objects using parameterized constructor
                Student student1 = new Student(101, "Kinjal", 20);
                Student student2 = new Student(102, "Raj", 19);
                Student student3 = new Student(103, "Meera", 21);
                Student student4 = new Student(104, "Amit", 22);
                Student student5 = new Student(105, "Priya", 20);

                // Display details of all students
                student1.DisplayStudent();
                student2.DisplayStudent();
                student3.DisplayStudent();
                student4.DisplayStudent();
                student5.DisplayStudent();

                Console.ReadLine(); // Keep console open
            }
        }
    }
}
