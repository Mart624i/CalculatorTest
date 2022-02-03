using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            if (a==0 || b == 0)
            {
                Console.WriteLine("Hell no! Returning 0.");

                return 0;
            }
            return a / b;
        }
    }
}