using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q6
    {
        class Line
        {
            private double length;   // Length of a line

            // Constructor
            public Line()
            {
                // Missing statement-1: set initial length
                length = 10;

                // Missing statement-2: print message
                Console.WriteLine("Object is being created, length = {0}", length);
            }

            public void setLength(double len)
            {
                // Missing statement-3: assign value to length
                length = len;
            }

            public double getLength()
            {
                // Missing statement-4: return length
                return length;
            }
        }
        class TestLine
        {
            static void Main(string[] args)
            {
                Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");


                Line line = new Line();   // constructor runs here

                // show initial length
                Console.WriteLine("Length of line : {0}", line.getLength());

                // change length
                line.setLength(6);

                // show updated length
                Console.WriteLine("Length of line : {0}", line.getLength());

                Console.ReadKey();
            }
        }

    }
}
