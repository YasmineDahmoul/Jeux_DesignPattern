using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesignPatternCL.Models.Actions
{
    public class NotificationAction : IAction
    {
        public void ActionForme()
        {
        }

        public string GetAction()
        {
            return "Notification";
        }

        public void ShowNotification()
        {
            Console.WriteLine("Show notification");
        }

        public void HideNotification()
        {
            Console.WriteLine("Hide notification");
        }

    }
}
