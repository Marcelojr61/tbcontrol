using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Notifications;

namespace TBControl.Business.Interfaces
{
    public interface INotifier
    {
        void Handle(Notification notification);
        List<Notification> GetNotifications();
        bool HasNotification();

    }
}
