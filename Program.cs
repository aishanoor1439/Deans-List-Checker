using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deans_List_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: GPA of the student
            Console.WriteLine("Enter your GPA:");
            double gpa = double.Parse(Console.ReadLine());

            // Checking if the GPA qualifies for the Dean's list
            if (gpa >= 3.5 && gpa <= 4.0)
            {
                // If GPA is 3.5 or above
                Console.WriteLine("Congratulations—you made the Dean's List!");
            }
            else if(gpa < 3.5)
            {
                // If GPA is below 3.5
                Console.WriteLine("Sorry, you didn't make the Dean's List.");
            }
            else 
            {
                Console.WriteLine("Invalid GPA entered.");
            }

        }
    }
}
