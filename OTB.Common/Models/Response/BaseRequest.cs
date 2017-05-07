using OTB.Common.ErrorHandling;

namespace OTB.Common.Models.Response
{
    public class BaseRequest
    {
        public BaseRequest()
        {
            Notification = new NotificationCollection();
        }

        public NotificationCollection Notification { get; set; }

        public bool IsValid { get; set; }
    }
}
