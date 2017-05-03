using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTB.Common.Logging
{
    public interface ILogger
    {
        void Error(Exception exception);

        void Error(string message);
    }
}
