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
                Procedures();
                choice = LoopChoiceValidation();        //validation of user's choice
            }
            while (choice == 'Y' || choice == 'y');
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
        public static void Procedures()
        {
            int birthYear = InputBirthYear();               //identifying the user's birthyear.
            int age = CalculateAge(birthYear);              //calculate age.
            string henerasyon = IdentifyGeneration(age);    //identifying the user's generation.
            string stages = IdentifyingLifeStage(age);      //identifying the life stage the user is at.

            Console.WriteLine($"If the birth year is {birthYear}, then the person would be {age} years old, {henerasyon}, and in their {stages} of life");
        }
        public static int InputBirthYear()
        {
            int birthYear;
            Console.Write("Enter your year of birth: ");
            while (!int.TryParse(Console.ReadLine(), out birthYear))    //input validation
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
                Console.Write("Enter your year of birth: ");
            }
            return birthYear;
        }
        public static int CalculateAge(int num1)
        {
            int age = 2024 - num1;
            return age;
        }
        public static string IdentifyGeneration(int age)
        {
            string henerasyon = "";
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
            return henerasyon;
        }
        public static string IdentifyingLifeStage(int age)
        {
            string stages = "";
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
            else if (age > 80)
            {
                stages = "Late Adulthood";
            }
            return stages;
        }
        public static char LoopChoiceValidation()
        {
            char choice;
            Console.WriteLine("\nWould you like to use it again? [y/n]");
            while (!char.TryParse(Console.ReadLine(),out choice) || choice != 'y' && choice != 'n' )
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Only input  [y] for yes or [n] for no");
                Console.WriteLine("Would you like to use it again? y/n");
            }
            return choice;
        }
    }
}