using System;

namespace Utils.String
{
    /// <summary>
    /// String-related utilities that the standard string class doesn't provide.
    /// </summary>
    public static class StringUtils
    {
        /// <summary>
        /// Returns a copy of this string that's reversed.
        /// </summary>
        /// <returns>The string in reverse.</returns>
        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Returns a copy of this string that's in alphabetical order.
        /// </summary>
        /// <returns>The string in alphabetical order.</returns>
        public static string Alphabetical(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
