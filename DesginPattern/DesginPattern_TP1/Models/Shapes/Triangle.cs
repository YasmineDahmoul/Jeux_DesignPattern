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
  public class Triangle : Forme
  {
    #region Constractors

    public Triangle(IAction action, Container container)
    {
      Container = container;
      Action = action;
    }

    public override int GetPoid()
    {
      return 0;
    }

    #endregion


    public override string GetForm()
    {
      return "Square";
    }

    public override FormeFactory.Type GetType()
    {
      return FormeFactory.Type.Triangle;
    }
  }
}
