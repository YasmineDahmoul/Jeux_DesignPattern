using DesignPatternCL.Actions.Models;
using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Commands
{
  public class ResizeFormCommand : ICommand
  {
    private ResizeAction Resize;

    public ResizeFormCommand(ResizeAction _Resize)
    {
      this.Resize = _Resize;
    }

    public void Cancel()
    {
      Resize.StopResizing();
    }

    public void Execute()
    {
      Resize.Resizing();
    }
  }
}
