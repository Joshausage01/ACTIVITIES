/* Practice 3
 *  Write a C# program that does the following:
 *  - user will input number of days
 *  - program will display the corresponding day
 *  - program will ask the user to input another input of number to add to the day number
 *  - program will compute and display the corresponding day
*/
using System;

namespace DayCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Monday");
            Console.WriteLine("(2) Tuesday");
            Console.WriteLine("(3) Wednesday");
            Console.WriteLine("(4) Thursday");
            Console.WriteLine("(5) Friday");
            Console.WriteLine("(6) Saturday");
            Console.WriteLine("(7) Sunday");
            Console.Write("\nInput day number: ");
            int dayInput;

            while (!int.TryParse(Console.ReadLine(), out dayInput))
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Pick number 1-7.");
                Console.Write("Input day number: ");
            }

            switch (dayInput)
            {
                case 1:
                    Console.WriteLine("The day is Monday");
                    break;
                case 2:
                    Console.WriteLine("The day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("The day is Friday");
                    break;
                case 6:
                    Console.WriteLine("The day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("The day is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }

            Console.Write("Input number of days to be added: ");
            int numberDays;

            while (!int.TryParse(Console.ReadLine(), out numberDays))
            {
                Console.WriteLine("Invalid Input. Pick number 1-7.");
                Console.Write("Input number of days to be added: ");
            }

            int newDay = (dayInput + numberDays) % 7;
            switch (newDay)
            {
                case 1:
                    Console.WriteLine("The new day is Monday");
                    break;
                case 2:
                    Console.WriteLine("The new day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The new day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The new day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("The new day is Friday");
                    break;
                case 6:
                    Console.WriteLine("The new day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("The new day is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}