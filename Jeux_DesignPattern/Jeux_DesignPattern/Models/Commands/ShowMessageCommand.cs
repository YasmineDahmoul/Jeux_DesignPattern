using Jeux_DesignPattern.Interfaces;
using Jeux_DesignPattern.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Commands
{
    public class ShowMessageCommand : ICommand
    {
        private NotificationAction NotificationAction;

        public ShowMessageCommand(NotificationAction notifcationAction)
        {
            this.NotificationAction = notifcationAction;
        }

        public void Execute()
        {
            NotificationAction.ShowNotification();
        }

        public void Cancel()
        {
            NotificationAction.HideNotification();
        }
    }
}
