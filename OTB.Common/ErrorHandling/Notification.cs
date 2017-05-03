using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTB.Common.ErrorHandling
{
    public class Notification
    {
        private Error error = new Error();

        public Notification() { }

        public Notification(string error)
        {
            this.error = new Error(error);
        }

        public Notification(Error error)
        {
            this.error = error;
        }

        public Error Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;
            }
        }
    }
}
