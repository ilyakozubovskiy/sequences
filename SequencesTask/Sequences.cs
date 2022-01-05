using System;
using System.Text.RegularExpressions;

namespace SequencesTask
{
    public static class Sequences
    {
        /// <summary>
        /// Find all the contiguous substrings of length length in given string of digits in the order that they appear.
        /// </summary>
        /// <param name="numbers">Source string.</param>
        /// <param name="length">Length of substring.</param>
        /// <returns>All the contiguous substrings of length n in that string in the order that they appear.</returns>
        /// <exception cref="ArgumentException">
        /// Throw if length of substring less and equals zero
        /// -or-
        /// more than length of source string
        /// - or-
        /// source string containing a non-digit character
        /// - or
        /// source string is null or empty or white space.
        /// </exception>
        public static string[] GetSubstrings(string numbers, int length)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentException($"{nameof(numbers)} cannot be null or empty or whitespace");
            }

            if (length > numbers.Length || length < 1)
            {
                throw new ArgumentException($"{nameof(numbers)} cannot be negative or zero or greater than the length of the source string");
            }

            if (!new Regex(@"^[0-9]+$").IsMatch(numbers))
            {
                throw new ArgumentException($"{nameof(numbers)} contains non-digit character");
            }

            string[] result = new string[numbers.Length - length + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numbers.Substring(i, length);
            }

            return result;
        }
    }
}
