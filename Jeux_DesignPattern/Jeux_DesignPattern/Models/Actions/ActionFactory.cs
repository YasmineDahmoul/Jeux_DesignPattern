using Jeux_DesignPattern.Actions.Models;
using Jeux_DesignPattern.Interfaces;
using Jeux_DesignPattern.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Actions
{
  public class ActionFactory
  {
    public enum ActionType
    {                                 
      Resize,
      Move,
      Notification
    };

    private ActionFactory() { }

    public static IAction Create(ActionType actionType)
    {
      switch (actionType)
      {
        case ActionType.Resize:
          return new ResizeAction();
        case ActionType.Move:
          return new MoveAction();
        case ActionType.Notification:
          return new NotificationAction();
        default:
          return new MoveAction();
      }
    }
  }
}
