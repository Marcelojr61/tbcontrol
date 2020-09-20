using System;
using System.Collections.Generic;
using System.Text;

namespace TBControl.Business.Notifications
{
    public class Notification
    {
        public Notification(string message)
        {
            this.Message = message;
        }

        public string Message { get; }
    }
}
