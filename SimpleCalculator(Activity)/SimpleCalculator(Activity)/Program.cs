/*Practical 2
 * Write a C# program that does the ff:
 * - Display operation (ADD, SUBTRACTION, MULTIPLICATION, DIVISION)
 * - Ask the user to input 2 numbers
 * - Program will perform the selected operation on the 2 numbers and display the result
 */

namespace SimpleCalculator_Activity_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) ADD");
            Console.WriteLine("(2) SUBTRACT");
            Console.WriteLine("(3) MULTIIPLY");
            Console.WriteLine("(4) DIVIDE");
            Console.WriteLine("Select preferred operation: ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please Try again.");
                Console.WriteLine("Select preferred operation: ");
            }

            Console.WriteLine("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int sum = num1 + num2;
                Console.WriteLine($"ADD {num1} and {num2} the result is {sum}");
            }
            else if (choice == 2)
            {
                if (num1 > num2)
                {
                    int difference = num1 - num2;
                    Console.WriteLine($"SUBTRACT {num2} from {num1} and the result is {difference}");
                }
                else
                {
                    int difference = num2 - num1;
                    Console.WriteLine($"SUBTRACT {num1} from {num2} and the result is {difference}");
                }
            }
            else if (choice == 3)
            {
                int product = num1 * num2;
                Console.WriteLine($"MULTIPLY {num1} and {num2} and the result is {product}");
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine("the Second number cannot be zero (0)");
                }
                else if (num1 > num2)
                {
                    double quotient = num1 / num2;
                    Console.WriteLine($"DIVIDE {num1} by {num2} and the result is {quotient}");
                }
                else
                {
                    Console.WriteLine("Invalid input. The first number should be greater than second number");
                }
            }
        }
    }
}