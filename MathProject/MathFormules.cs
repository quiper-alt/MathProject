using System;

namespace MathProject
{
    public class MathFormules
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static double Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            return a / b;
        }

        public static double Square(int a)
        {
            return a * a;
        }

        public static double CubePower(int a)
        {
            return Math.Pow(a, 3);
        }

        public static double SquaredSum(int a, int b)
        {
            return Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
        }

        public static double SquaredDifference(int a, int b)
        {
            return Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
        }

        public static double Discriminant(int a, int b, int c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public static double SquareTriangle(int a, int b)
        {
            return 0.5 * a * b;
        }
    }
}