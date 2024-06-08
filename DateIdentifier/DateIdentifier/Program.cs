/*Practice 5
 * Write a C# program that does the following:
 * - user will input a month number
 * - user will input a day number
 * - program will display the corresponding month and day
*/

using System;

namespace DateIdentifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input month number: ");
            int numMonth;
            while (!int.TryParse(Console.ReadLine(), out numMonth) || numMonth < 1 || numMonth > 12)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
                Console.Write("Input month number: ");
            }
            Console.Write("Input day number: ");
            int numDay;
            while (!int.TryParse(Console.ReadLine(), out numDay) || numDay < 1 || numDay > 30)
            {
                Console.WriteLine("Invalid Input");
                Console.Write("Input day number: ");
            }

            string month = "";
            string day = "";
            switch (numMonth)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    break;
            }

            switch (numDay)
            {
                case 1:
                    day = "One";
                    break;
                case 2:
                    day = "Two";
                    break;
                case 3:
                    day = "Three";
                    break;
                case 4:
                    day = "Four";
                    break;
                case 5:
                    day = "Five";
                    break;
                case 6:
                    day = "Six";
                    break;
                case 7:
                    day = "Seven";
                    break;
                case 8:
                    day = "Eight";
                    break;
                case 9:
                    day = "Nine";
                    break;
                case 10:
                    day = "Ten";
                    break;
                case 11:
                    day = "Eleven";
                    break;
                case 12:
                    day = "Twelve";
                    break;
                case 13:
                    day = "Thirteen";
                    break;
                case 14:
                    day = "Fourteen";
                    break;
                case 15:
                    day = "Fifteen";
                    break;
                case 16:
                    day = "Sixteen";
                    break;
                case 17:
                    day = "Seventeen";
                    break;
                case 18:
                    day = "Eighteen";
                    break;
                case 19:
                    day = "Nineteen";
                    break;
                case 20:
                    day = "Twenty";
                    break;
                case 21:
                    day = "Twenty-One";
                    break;
                case 22:
                    day = "Twenty-Two";
                    break;
                case 23:
                    day = "Twenty-Three";
                    break;
                case 24:
                    day = "Twenty-Four";
                    break;
                case 25:
                    day = "Twenty-Five";
                    break;
                case 26:
                    day = "Twenty-Six";
                    break;
                case 27:
                    day = "Twenty-Seven";
                    break;
                case 28:
                    day = "Twenty-Eight";
                    break;
                case 29:
                    day = "Twenty-Nine";
                    break;
                case 30:
                    day = "Thirty";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"The date is {month} {day}.");
        }
    }
}