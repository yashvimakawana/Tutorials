using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q1
    {
        class Car
        {
            // Task 2: Private data members (cannot be accessed directly outside class)
            private string brand;
            private string model;
            private int speed;

            // Task 3: Public methods to work on private data members

            // Set brand of the car
            public void SetBrand(string b)
            {
                brand = b;
            }

            // Set model of the car
            public void SetModel(string m)
            {
                model = m;
            }

            // Set speed of the car
            public void SetSpeed(int s)
            {
                speed = s;
            }

            // Display car details
            public void ShowDetails()
            {
                Console.WriteLine("Car Brand: " + brand);
                Console.WriteLine("Car Model: " + model);
                Console.WriteLine("Car Speed: " + speed + " km/h");
                Console.WriteLine("---------------------------");
            }
        }

        // Task 4: Demo class with Main method
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
                // Task 5: Create objects of Car class

                // Object 1
                Car myCar1 = new Car();
                myCar1.SetBrand("Honda");
                myCar1.SetModel("City");
                myCar1.SetSpeed(120);
                myCar1.ShowDetails();

                // Object 2
                Car myCar2 = new Car();
                myCar2.SetBrand("Toyota");
                myCar2.SetModel("Corolla");
                myCar2.SetSpeed(100);
                myCar2.ShowDetails();

                // Keep console window open
                Console.ReadLine();
            }
        }

    }
}
