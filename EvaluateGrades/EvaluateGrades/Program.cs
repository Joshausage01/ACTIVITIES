/* 
 * Write a C# program that does the following:
 * - User will input 2 grades.
 * - The program will calculate the average and display the corresponding grade equivalent of the average grade.
 * - Incorporate the usage of methods/functions.
*/ 
 
using System;

namespace EvaluateGrades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**INPUT 2 GRADE VALUES**");
            Console.Write("Input first grade: ");
            int grade1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second grade: ");
            int grade2 = Convert.ToInt32(Console.ReadLine());

            InputProcesses(grade1, grade2);
        }
        public static void InputProcesses(int num1, int num2)
        {
            if ((num1 < 0 || num1 > 100) || (num2 < 0 || num2 > 100))
            {
                Console.WriteLine("Invalid input.");
            }
            else 
            {
                double average = CalculateAverage(num1, num2);
                string text = AverageEquivalent(average);
            }
        }
        public static double CalculateAverage(int num1, int num2)
        {
            int sum = num1 + num2;
            double average = sum / 2.0;   //casting the sum to convert into double
            Console.WriteLine($"-----Solution: {sum} / 2 \tAverage grade value: {average}-----");
            return average;
        }
        public static string AverageEquivalent(double num1)
        {
            string text = "";
            if (num1 > 90 && num1 <= 100)
            {
                text = "EXCELLENT";
            }
            else if (num1 > 80 && num1 <= 90)
            {
                text = "VERY GOOD";
            }
            else if (num1 > 70 && num1 <= 80)
            {
                text = "GOOD";
            }
            else if (num1 > 50 && num1 <= 70)
            {
                text = "FAIR";
            }
            else
            {
                text = "FAILED";
            }
            Console.WriteLine(text);

            return text;
        }
    }
}
