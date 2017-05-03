using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTB.Common.Logging
{
    public class DebugLogger : ILogger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public void Error(Exception ex)
        {
            Console.WriteLine(ex);
        }

        public void Error(string message)
        {
            Console.WriteLine(message);
        }

    }
}
