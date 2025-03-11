using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DelegatesHomework
{
    public class Notifier
    {
        public delegate void NotificationHandler(string message);
        public NotificationHandler? OnNotify;
        public event NotificationHandler? NotifyEvent;

        public void TriggerEvent(string message)
        {
            if (StringLength(message) > 5)
                NotifyEvent?.Invoke(message);
        }
        public void SendNotification(string message)
        {
            OnNotify?.Invoke(message);
        }
        public static int StringLength(string input)
        {
            return input.Length;
        }
    }
}