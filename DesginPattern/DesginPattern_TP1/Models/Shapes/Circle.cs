using DesignPatternCL.Interfaces;
using DesignPatternCL.Models;
using DesignPatternCL.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Shapes
{
  public class Circle : Forme
  {
    #region Constractors

    public Circle(IAction action, Container container) 
    {
      Container = container;
      Action = action;
    }

    public override int GetPoid()
    {
      return 0;
    }

    #endregion

    #region Operations


    #endregion

    public override string GetForm()
    {
      return "Circle";
    }

    public override FormeFactory.Type GetType()
    {
      return FormeFactory.Type.Circle;
    }
  }
}
