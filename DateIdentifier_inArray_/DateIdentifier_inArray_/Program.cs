/*Practice 5 {Array version}
 * Write a C# program that does the following:
 * - user will input a month number
 * - user will input a day number
 * - program will display the corresponding month and day
*/
using System;

namespace DateIdentifier_inArray_
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] months = { " ", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] days = { " ", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Twenty-One", "Twenty-Two", "Twenty-Three", "Twenty-Four", "Twenty-Five", "Twenty-Six", "Twenty-Seven", "Twenty-Eight", "Twenty-Nine", "Thirty" };

            Console.Write("Input month number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input day number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            CheckValidMonthAndDays(monthNumber, dayNumber,months, days);
        }
        public static void CheckValidMonthAndDays(int num1, int num2, string[] months, string[] days)
        {
            if ((num1 >= 1 && num1 <= 12) && (num2 >= 1 && num2 <=12))
            {
                Console.WriteLine($"The date is {months[num1]} {days[num2]}");
            }
            else
            {
                Console.WriteLine("Invalid Month/Day Input. Input for Months (1-12). Input for Days(1-30)");
            }
        }
    }
}
