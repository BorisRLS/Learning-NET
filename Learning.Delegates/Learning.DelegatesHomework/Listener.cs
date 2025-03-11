using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DelegatesHomework
{
    internal class Listener : Notifier
    {
        public void OnNotificationReceived(string message)
        {
            Console.WriteLine($"[Listener]: {message}");
        }
    }
}
