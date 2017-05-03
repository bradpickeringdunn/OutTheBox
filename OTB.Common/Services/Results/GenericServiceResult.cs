using OTB.Common.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OTB.Common.Services.Results
{
    [DataContract]
    public class GenericServiceResult
    {
        public GenericServiceResult()
        {
            Notifications = new NotificationCollection();
        }

        [DataMember]
        public NotificationCollection Notifications { get; set; }
    }
}
