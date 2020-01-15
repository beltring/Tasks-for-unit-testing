using System;

namespace Task1
{
    /// <summary>
    /// The StringHelper class makes it easier to work with strings.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Method for counting the number of vowel letters in a string.
        /// </summary>
        /// <param name="str">Input string.</param>
        /// <returns>The method returns the number of vowel letters in a string.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="str"/>
        /// String cannot be null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="str"/>
        /// String cannot be empty.
        /// </exception>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("String cannot be empty.");
            }

            int count = 0;
            foreach (var ch in str)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
