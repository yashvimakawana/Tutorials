using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t3_q2
    {
        class Clock
        {
            // Private data members
            private int hour;
            private int min;
            private int sec;

            // No-argument constructor: initialize to 12:00:00
            public Clock()
            {
                hour = 12;
                min = 0;
                sec = 0;
            }

            // Three-argument constructor: initialize with given values
            public Clock(int h, int m, int s)
            {
                hour = h;
                min = m;
                sec = s;
            }

            // Method to increment time by one second
            public void IncrementSecond()
            {
                sec++; // increment seconds

                // Check if seconds exceed 59
                if (sec >= 60)
                {
                    sec = 0;
                    min++; // increment minutes

                    // Check if minutes exceed 59
                    if (min >= 60)
                    {
                        min = 0;
                        hour++; // increment hours

                        // Check if hours exceed 23
                        if (hour >= 24)
                        {
                            hour = 0; // reset hours to 0
                        }
                    }
                }
            }

            // Method to display time in HH:MM:SS format
            public void DisplayTime()
            {
                Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
            }

            // Getter method for hour
            public int GetHour()
            {
                return hour;
            }

            // Getter method for minute
            public int GetMinute()
            {
                return min;
            }

            // Getter method for second
            public int GetSecond()
            {
                return sec;
            }
        }

        // Demo class with Main method
        class Program
        {
            static void Main(string[] args)
            {
                //Console.WriteLine("24SOECE13033 - YASHVI MAKWANA");
                Console.WriteLine("24SOECE13032 - KINJAL KHIMSURIYA");

                // Create clock object using no-argument constructor
                Clock clock1 = new Clock();
                Console.WriteLine("Clock1 initial time:");
                clock1.DisplayTime();

                // Increment the time by one second
                clock1.IncrementSecond();
                Console.WriteLine("Clock1 after incrementing 1 second:");
                clock1.DisplayTime();

                // Create clock object using three-argument constructor
                Clock clock2 = new Clock(23, 59, 59);
                Console.WriteLine("Clock2 initial time:");
                clock2.DisplayTime();

                // Increment the time by one second (should roll over)
                clock2.IncrementSecond();
                Console.WriteLine("Clock2 after incrementing 1 second:");
                clock2.DisplayTime();

                // Display individual hour, minute, second using getters
                Console.WriteLine($"Clock2 Hour: {clock2.GetHour()}");
                Console.WriteLine($"Clock2 Minute: {clock2.GetMinute()}");
                Console.WriteLine($"Clock2 Second: {clock2.GetSecond()}");

                Console.ReadLine(); // keep console open
            }
        }
    }
}
