using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OTB.Common.CodeValidation
{
    public static class Guard
    {
        public static void ArgumentNotNull(object argument)
        {
            if (argument.IsNull())
            {
                var type = argument.GetType();

                var exceptionMessage = GetExceptioningClassInformation(type.Name);

                throw new ArgumentNullException(type.Name, exceptionMessage);
            }
        }

        public static void InstanceNotNull(object argument, string exceptionMessage)
        {
            if (argument.IsNull())
            {
                var type = argument.GetType();
                
                throw new ArgumentNullException(type.Name, exceptionMessage);
            }
        }

        public static void InstanceNotNull(object argument)
        {
            if (argument.IsNull())
            {
                var type = argument.GetType();

                var exceptionMessage = GetExceptioningClassInformation(type.Name);

                throw new ArgumentNullException(type.Name, exceptionMessage);
            }
        }

        private static string GetExceptioningClassInformation(string argumentName)
        {
            var stackTrace = new System.Diagnostics.StackTrace();
            var frame = stackTrace.GetFrames()[1];
            var method = frame.GetMethod();
            var methodName = method.Name;
            var methodsClass = method.DeclaringType;

            return string.Format("Class: {0}, Method: {1}, Param: {2}", methodsClass.FullName, methodName, argumentName);


        }
    }
}
