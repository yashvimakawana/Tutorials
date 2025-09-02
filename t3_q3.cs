using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q3
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

        // Another class to demonstrate Student class
        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");

                // Create a student object using no-argument constructor
                Student student1 = new Student();
                student1.DisplayStudent();

                // Create a student object using parameterized constructor
                Student student2 = new Student(101, "Kinjal", 20);
                student2.DisplayStudent();

                // Demonstrate setting properties individually
                Student student3 = new Student();
                student3.RollNumber = 102;
                student3.Name = "Raj";
                student3.Age = 19;
                student3.DisplayStudent();

                Console.ReadLine(); // Keep console open
            }
        }
    }
}
