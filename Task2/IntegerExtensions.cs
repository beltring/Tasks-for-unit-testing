using System;

namespace Task2
{
    /// <summary>
    /// This class extends the functionality of the Integer class.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// This method implements the algorithm find the GCD of two numbers.
        /// </summary>
        /// <param name="a">The first input number.</param>
        /// <param name="b">The second input number.</param>
        /// <returns>GCD of two integers.</returns>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(string.Empty, "Invalid value, the value is greater than the allowed value.");
            }

            if (a == 0)
            {
                return Math.Abs(b);
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