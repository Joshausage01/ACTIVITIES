/* Practice 4
 * Write a C# program that does the ff:
 * - user will enter their year of birth
 * - the program will calculate and display the age, generation and age
*/

using System;

namespace GenerationIdentifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.Clear();
                Console.Write("Enter your year of birth: ");
                int birthYear;

                while (!int.TryParse(Console.ReadLine(), out birthYear))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input.");
                    Console.Write("Enter your year of birth: ");
                }
                int age = 2024 - birthYear;
                string henerasyon = "";
                string stages = "";

                if (age >= 79 && age <= 96)
                {
                    henerasyon = "The Silent Generation";
                }
                else if (age >= 60 && age <= 78)
                {
                    henerasyon = "Baby Boomers";
                }
                else if (age >= 44 && age <= 59)
                {
                    henerasyon = "Gen X";
                }
                else if (age >= 28 && age <= 43)
                {
                    henerasyon = "Millennials";
                }
                else if (age >= 12 && age <= 27)
                {
                    henerasyon = "Gen Z";
                }
                else if (age > 0 && age <= 11)
                {
                    henerasyon = "gen alpha";
                }


                if (age >= 0 && age <= 3)
                {
                    stages = "Infant";
                }
                else if (age > 3 && age <= 5)
                {
                    stages = "Early Childhood";
                }
                else if (age >= 6 && age <= 8)
                {
                    stages = "Middle Childhood";
                }
                else if (age >= 9 && age <= 11)
                {
                    stages = "Late Childhood";
                }
                else if (age >= 12 && age <= 20)
                {
                    stages = "Adoloscence";
                }
                else if (age >= 21 && age <= 35)
                {
                    stages = "Early Adulthood";
                }
                else if (age >= 36 && age <= 50)
                {
                    stages = "Midlife";
                }
                else if (age >= 51 && age <= 80)
                {
                    stages = "Mature Adulthood";
                }
                else if (age > 80 && age <= 100)
                {
                    stages = "Late Adulthood";
                }

                Console.WriteLine($"If the birth year is {birthYear}, then the person would be {age} years old, {henerasyon}, and in their {stages} of life");
                Console.WriteLine("\nWould you like to use it again? {Y/N}");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while (choice == 'Y' || choice == 'y');
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}