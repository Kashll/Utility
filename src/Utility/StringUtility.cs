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
    }
}
