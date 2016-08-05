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
    }
}
