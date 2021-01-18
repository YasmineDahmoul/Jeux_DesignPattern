using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Actions.Models
{
  public class MoveAction : IAction
  {
    public void ActionForme()
    {
      throw new NotImplementedException();
    }

    public string GetAction()
    {
      return "Move";
    }

    public void MoveUp()
    {

    }

    public void StopMoving()
    {

    }

  }
}
