using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OTB.Common.Utilities
{
    public static class Guardian
    {
        public static void InstanceNotNull(object instance, string name)
        {
            if (instance == null)
            {
                var assembly = Assembly.GetCallingAssembly();
                throw new NullReferenceException("{0} is null in assembly {1}".FormatLiteralArguments(name, assembly));
            }
        }

        public static void ArgumentNotNull(object argument, string name)
        {
            if (argument == null)
            {
                var assembly = Assembly.GetCallingAssembly();
                throw new NullReferenceException("{0} is null in assembly {1}".FormatLiteralArguments(name, assembly));
            }
        }
        
    }
}
