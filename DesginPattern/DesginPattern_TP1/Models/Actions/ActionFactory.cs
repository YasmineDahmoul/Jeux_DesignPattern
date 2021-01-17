using DesignPatternCL.Actions.Models;
using DesignPatternCL.Interfaces;
using DesignPatternCL.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Actions
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
