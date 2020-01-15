using System;

namespace Task2
{
    public static class IntegerExtensions
    {
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == 0)
            {
                return Math.Abs(b);
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }

            return Math.Abs(a);
        }
    }
}