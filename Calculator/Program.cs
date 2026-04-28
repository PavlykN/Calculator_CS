using System;

namespace Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CalculatorEngine engine = new CalculatorEngine();

        var operations = new Dictionary<int, Action>
        {
            { 1, () => ExecuteBinaryOperator("addition", engine.Sum) },
            { 2, () => ExecuteBinaryOperator("subtraction", engine.Subtraction) },
            { 3, () => ExecuteBinaryOperator("multiplication", engine.Multiplication) },
            { 4, () => ExecuteBinaryOperator("division", engine.Division) },
            { 5, () => ExecuteUnaryOperator("Enter a number:", engine.FindSqrt) },
            { 6, () => ExecuteBinaryOperator("raising to a power", engine.FindPow) },
        };

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Find the square root of a number");
            Console.WriteLine("6. Raise a number to a power");
            Console.WriteLine();

            int operation = IntInput();

            if (operations.TryGetValue(operation, out var action))
            {
                action();
            }
            else
            {
                Console.WriteLine("Incorrect operation");
            }

            Console.WriteLine("Would you like to make more calculations? (y/n)");
            string continueChoice = Console.ReadLine()?.ToLower().Trim();

            if (continueChoice == "y")
            {
                Console.WriteLine();
                continue;
            }
            else if (continueChoice == "n")
            {
                Console.WriteLine("End of the program...");
                break;
            }
            else
            {
                Console.WriteLine("Unknown response. Program terminating...");
                break;
            }
        }
    }

    static void ExecuteBinaryOperator(string opName, Func<double, double, double> operation)
    {
        double first = DoubleInput($"Enter the first number for {opName}");
        double second = DoubleInput("Enter the second number");
        try
        {
            double result = operation(first, second);
            Console.WriteLine($"Result: {result}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }

    static void ExecuteUnaryOperator(string message, Func<double, double> operation)
    {
        double val = DoubleInput(message);
        try
        {
            Console.WriteLine($"Result: {operation(val)}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }

    public static int IntInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Enter an integer\n");
            }
        }
    }

    public static double DoubleInput(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Enter a number, not a letter\n");
            }
        }
    }
}

