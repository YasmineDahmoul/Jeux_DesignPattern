using DesignPatternCL.Interfaces;
using DesignPatternCL.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Commands
{
  public class ShowMessageCommand : ICommand
  {
    private NotificationAction messageAction;

    public ShowMessageCommand(NotificationAction _messageAction)
    {
      messageAction = _messageAction;
    }

    public void Cancel()
    {
      messageAction.HideNotification();
    }

    public void Execute()
    {
      messageAction.ShowNotification();
    }
  }
}
