/*
 * Write a C# program that does the following:
 *  - user will input number of days
 *  - program will display the corresponding day
 *  - program will ask the user to input another input of number to add to the day number
 *  - program will compute and display the corresponding day
*/

using System;
namespace AddDays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input day number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber <= 0 || dayNumber > 7)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            string day1 = GetDays(dayNumber);
            Console.WriteLine($"The day is {day1}");

            Console.Write("Input number to add to day: ");
            int newDay = Convert.ToInt32(Console.ReadLine());

            FinalDayValidation(dayNumber, newDay);
        }
        public static void FinalDayValidation(int num1,int num2)
        {
            if (num2 <= 0 || num2 > 7)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            int finalDay = SolveFinalDay(num1, num2);
            string day2 = GetDays(finalDay);
            Console.WriteLine($"The new day is {day2}");
        }
        public static string GetDays(int num1) 
        {
            switch (num1)
            {
                case 1:
                    return "MONDAY";
                case 2:
                    return "TUESDAY";
                case 3:
                    return "WEDNESDAY";
                case 4:
                    return "THURSDAY";
                case 5:
                    return "FRIDAY";
                case 6:
                    return "SATURDAY";
                case 7:
                    return "SUNDAY";
                default:
                    return "Invalid input.";
            }
        }
        public static int SolveFinalDay(int num1, int num2)
        {
            int finalDay = (num1 + num2) % 7;
            return finalDay;
        }
    }
}