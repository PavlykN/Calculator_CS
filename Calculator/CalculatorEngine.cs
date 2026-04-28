using System;

namespace Calculator
{
    public class CalculatorEngine
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Subtraction(double x, double y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("You can't divide by zero");
            }
            return x / y;
        }

        public double FindSqrt(double x)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(x), "The number must be positive");
            }
            return Math.Sqrt(x);
        }

        public double FindPow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}