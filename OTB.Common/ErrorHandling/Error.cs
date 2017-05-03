using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTB.Common.ErrorHandling
{
    public class Error
    {
        private string message = string.Empty;
        private ErrorSeverity errorSeverity = ErrorSeverity.Low;

        public Error(){}

        public Error(string message)
        {
            this.message = message;
        }

        public Error(string message, ErrorSeverity severity)
        {
            this.message = message;
            this.errorSeverity = severity;
        }

        public string ErrorMessage
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public ErrorSeverity Severity
        {
            get
            {
                return errorSeverity;
            }
            set
            {
                errorSeverity = value;
            }
        }
    }

    public enum ErrorSeverity
    {
        Hight = 1,
        Medium = 2,
        Low = 3
    }
}
