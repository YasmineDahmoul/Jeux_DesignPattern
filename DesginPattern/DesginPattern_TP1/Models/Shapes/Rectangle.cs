using DesignPatternCL.Interfaces;
using DesignPatternCL.Models;
using DesignPatternCL.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesignPatternCL.Models.Shapes
{
  public class Rectangle : Forme
  {
    public List<Forme> Forms = new List<Forme>();

    #region Operations

    public override void AddForm(Forme shape)
    {
      this.Forms.Add(shape);
    }

    public override void DeleteForm(Forme shape)
    {
      this.Forms.Remove(shape);
    }

    public override string Details(int depth = 2)
    {
      string result = new string('-', depth) + $" {GetForm()}\n";
      foreach (var shape in Forms)
        result += $"{shape.Details(depth + 4)}";
      return result;
    }

    #endregion

    #region Constratctors

    public Rectangle(IAction action, Container container)
    {
      Container = container;
      Action = action;
    }

    public Rectangle(IAction action, List<Forme> forms,Container container)
    {
      Action = action;
      Forms = new List<Forme>(forms);
      Container = container;
    }

    #endregion

    public override string GetForm()
    {
      return "Rectangle";
    }

    public override FormeFactory.Type GetType()
    {
      return FormeFactory.Type.Rectangle;
    }

    public override int GetPoid()
    {
      return 0;
    }
  }
}
