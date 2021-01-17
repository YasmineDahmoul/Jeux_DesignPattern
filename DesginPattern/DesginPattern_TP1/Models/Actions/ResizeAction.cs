using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Actions.Models
{
  public class ResizeAction : IAction
  {
    public void DoSomething()
    {
      throw new NotImplementedException();
    }

    public string GetAction()
    {
      return "Resize";
    }

    public void Resizing()
    {

    }

    public void StopResizing()
    {

    }

  }
}
