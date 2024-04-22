using System;

namespace GeneralAverageGenerator
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("How many values do you need");
            int inputValues;

            while (!int.TryParse(Console.ReadLine(), out inputValues) || inputValues <= 0)
            {
                Console.WriteLine("Invalid Input. Please enter a number or any positive value");
                Console.WriteLine("How many values do you need");
            }

            double sum = 0;
            for (int i = 0; i < inputValues; i++)
            {
                Console.WriteLine($"Input Value {i + 1}"); //($) string interpolation
                double values;
                while (!double.TryParse(Console.ReadLine(), out values) || values < 0 || values > 100)
                {
                    Console.WriteLine("Invalid Input. Please use any positive number");
                    Console.WriteLine($"Input Value {i + 1}");
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
        }
    }
}