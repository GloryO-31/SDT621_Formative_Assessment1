using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            double mark1 = GetMark("Enter mark 1: ");
            double mark2 = GetMark("Enter mark 2: ");
            double mark3 = GetMark("Enter mark 3: ");

            double total = mark1 + mark2 + mark3;
            double average = total / 3;

            string status = (average >= 50) ? "PASS" : "FAIL";

            Console.WriteLine("\n==== STUDENT RESULTS ====");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Result: " + status);
        }

        static double GetMark(string message)
        {
            double mark;
            Console.Write(message);

            while (!double.TryParse(Console.ReadLine(), out mark))
            {
                Console.Write("Invalid input. Enter a number: ");
            }

            return mark;

        }
    }
}
