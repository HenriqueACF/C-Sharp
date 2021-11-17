using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;

namespace BaltaApplicationOOP.NotificationContext
{
    public  abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool isInvalid => Notifications.Any();
    }
}