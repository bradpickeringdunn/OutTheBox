using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTB.Common.ErrorHandling
{
    public class NotificationCollection : CollectionBase
    {
        public NotificationCollection()
        {
            notifications = new List<Notification>();
        }

        IList<Notification> notifications;

        public void Add(Notification notification)
        {
            notifications.Add(notification);
        }

        public void Add(Error error)
        {
            notifications.Add(new Notification(error));
        }

        public void Add(string error)
        {
            notifications.Add(new Notification(error));
        }
                
        public bool HasErrors
        {
            get
            {
                return notifications.IsNotNull() && notifications.Count > 0 ? true : false;
            }
        }

        public IList<Notification> Notifications
        {
            get
            {
                return notifications;
            }
        }
    }
}
