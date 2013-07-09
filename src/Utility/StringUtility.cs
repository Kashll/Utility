using System.Globalization;

namespace Utility
{
    public static class StringUtility
    {
        /// <summary>
        /// Extension method for a given format string and arguments using invariant culture
        /// </summary>
        public static string FormatInvariant(this string formatString, params object[] args)
        {
            return string.Format(CultureInfo.InvariantCulture, formatString, args);
        }

        /// <summary>
        /// Extension method for string.IsNullOrEmpty
        /// </summary>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
