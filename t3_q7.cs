using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q7
    {
        class Student
        {
            // Private data members
            private int enrolmentNo;
            private string name;
            private int age;

            // Properties for EnrolmentNo and Name
            public int EnrolmentNo
            {
                get { return enrolmentNo; }
                set { enrolmentNo = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Property for Age (with simple validation)
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

            // Default constructor
            public Student()
            {
                enrolmentNo = 0;
                name = "Unknown";
                age = 18;
            }

            // Parameterized constructor
            public Student(int eno, string nm, int ag)
            {
                EnrolmentNo = eno;  // using property
                Name = nm;          // using property
                Age = ag;           // using property (validation applied)
            }

            // Method to display student details
            public void DisplayStudent()
            {
                Console.WriteLine("Student Details:");
                Console.WriteLine("Enrolment No: " + EnrolmentNo);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("--------------------------");
            }
        }

        // Test class to demonstrate properties
        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
                // Create student using default constructor
                Student s1 = new Student();
                s1.EnrolmentNo = 101;
                s1.Name = "Kinjal";
                s1.Age = 20;
                s1.DisplayStudent();

                // Create student using parameterized constructor
                Student s2 = new Student(102, "Raj", 19);
                s2.DisplayStudent();

                // Create another student and update properties later
                Student s3 = new Student();
                s3.EnrolmentNo = 103;
                s3.Name = "Meera";
                s3.Age = 21;
                s3.DisplayStudent();

                Console.ReadLine(); // Keep console window open
            }
        }
    }
}
