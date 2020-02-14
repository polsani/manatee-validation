using System.Collections.Generic;
using System.Linq;

namespace Manatee.Validation.Notifications
{
    public abstract class Notifiable
    {
        private readonly List<Notification> _notifications;

        protected Notifiable() => _notifications = new List<Notification>();

        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public bool Invalid => _notifications.Any();
        public bool Valid => !Invalid;

        public void AddNotification(int httpStatusCode, 
            string property, 
            string message, 
            object value, 
            Constraint constraint)
        {
            _notifications.Add(new Notification(httpStatusCode, property, message, value, constraint));
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable item)
        {
            AddNotifications(item.Notifications);
        }

        public void AddNotifications(params Notifiable[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }
    }
}