namespace Calculator
{

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double first, second;

            // start while
            while (true)
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("1. Додати");
                Console.WriteLine("2. Відняти");
                Console.WriteLine("3. Помножити");
                Console.WriteLine("4. Поділити");
                Console.WriteLine("5. Квадратний корінь першого числа");
                Console.WriteLine("6. Піднести перше число до степеня другого");

                int operation = IntInput();

                switch (operation)
                {
                    case 1:
                        first = DoubleInput("Введіть перше число");
                        second = DoubleInput("Введіть друге число");
                        Console.WriteLine($"Результат: {first + second}\n");
                        break;
                    case 2:
                        first = DoubleInput("Введіть перше число");
                        second = DoubleInput("Введіть друге число");
                        Console.WriteLine($"Результат: {first - second}\n");
                        break;
                    case 3:
                        first = DoubleInput("Введіть перше число");
                        second = DoubleInput("Введіть друге число");
                        Console.WriteLine($"Результат: {first * second}\n");
                        break;
                    case 4:
                        first = DoubleInput("Введіть перше число");
                        second = DoubleInput("Введіть друге число");

                        if (second == 0)
                            Console.WriteLine("На нуль ділити не можна\n");
                        else
                            Console.WriteLine($"Результат: {first / second}\n");
                        break;
                    case 5:
                        first = DoubleInput("Введіть число");

                        if (first < 0)
                            Console.WriteLine("Число має бути додатнім");
                        else
                            Console.WriteLine($"Результат: {Math.Sqrt(first)}\n");
                        break;
                    case 6:
                        first = DoubleInput("Введіть перше число");
                        second = DoubleInput("Введіть друге число");
                        Console.WriteLine($"Результат: {Math.Pow(first, second)}\n");
                        break;
                    default:
                        Console.WriteLine("Оберіть операцію 1-6\n");
                        break;
                }

                Console.WriteLine("Бажаєте зробити ще обчислення? (так/ні)");
                string continueChoice = Console.ReadLine()?.ToLower().Trim();

                if (continueChoice == "так")
                {
                    Console.WriteLine();
                    continue;
                }
                else if (continueChoice == "ні")
                {
                    Console.WriteLine("Завершення програми...");
                    break;
                }
                else
                {
                    Console.WriteLine("Невідома відповідь. Завершення програми...");
                    break;
                }

            }
            // end while
        }

        public static int IntInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                    return number;
                else
                    Console.WriteLine("Введіть ціле число\n");
            }
        }

        public static double DoubleInput(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt); 
                string input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                    return value;
                else
                    Console.WriteLine("Введіть число, а не букву\n");
            }
        }
    }
}
