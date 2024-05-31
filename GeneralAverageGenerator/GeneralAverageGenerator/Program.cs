using System;

namespace GeneralAverageGenerator
{
    public class Program
    {
        static void Main(String[] args)
        {
            char choice;
            do
            {
                Console.WriteLine("How many values do you need");
                int inputValues;

                while (!int.TryParse(Console.ReadLine(), out inputValues) || inputValues <= 0 || inputValues > 50)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input. Please enter a number or any positive value and numbers less than 50.");
                    Console.WriteLine("How many values do you need");
                }

                double sum = 0;
                for (int i = 0; i < inputValues; i++)
                {
                    Console.Write($"Input Value {i + 1}: "); //($) string interpolation
                    double values;

                    while (!double.TryParse(Console.ReadLine(), out values) || values < 0 || values > 100) //input invalidation
                    {
                        Console.WriteLine("Invalid Input. Please use any positive number or numbers less than or equal to 100.");
                        Console.Write($"Input Value {i + 1}: ");
                    }

                    sum += values;
                }
                Console.WriteLine("----------------------------------------------------");
                double average = sum / inputValues;
                Console.WriteLine("\nSOLUTION: {0} / {1} \nAverage Value = {2}", sum, inputValues, average);

                if (average > 95 && average <= 100)
                {
                    Console.WriteLine("Excellent!");
                }
                else if (average > 90 && average <= 95)
                {
                    Console.WriteLine("Impressive!");
                }
                else if (average > 85 && average <= 90)
                {
                    Console.WriteLine("Very Good!");
                }
                else if (average > 80 && average <= 85)
                {
                    Console.WriteLine("Good!");
                }
                else if (average > 74 && average <= 80)
                {
                    Console.WriteLine("Fair");
                }
                else
                {
                    Console.WriteLine("FAILED!");
                }

                //Repetition
                Console.WriteLine("\n----------------------------------------------------");
                Console.Write("Would you like to use the calculator again? [y/n]");
                while(!char.TryParse(Console.ReadLine(), out choice) || choice != 'y' && choice != 'n')
                {
                    Console.WriteLine("Invalid Input. Input only letter [y] or letter [n].");
                    Console.Write("\nWould you like to use the calculator again? [y/n]");
                }
            } while (choice == 'y');

            Console.WriteLine("Thank you for using the calculator...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}