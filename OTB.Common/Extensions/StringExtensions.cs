using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string @string)
        {
            var result = false;

            if(@string.IsNull() || @string == string.Empty)
            {
                result = true;
            }

            return result;
        }

        public static bool IsNotNullOrEmpty(this string @string)
        {
            var result = false;

            if (@string.IsNotNull() && @string != string.Empty)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Determins is a string is null
        /// </summary>
        public static bool IsNotNull(this string @string)
        {
            return @string != null ? true : false;
        }
        
        public static string FormatLiteralArguments(this string @string, params object[] args)
        {
            var result = @string;

            if (args.Any())
            {
                result = string.Format(@string, args);
            }

            return result;
        }
    }
}
