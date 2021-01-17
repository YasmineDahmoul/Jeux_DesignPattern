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
  public class Rectangle : Form
  {
    public List<Form> Forms = new List<Form>();

    #region Operations

    public override void AddForm(Form shape)
    {
      this.Forms.Add(shape);
    }

    public override void DeleteForm(Form shape)
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

    public Rectangle(IAction action, List<Form> forms,Container container)
    {
      Action = action;
      Forms = new List<Form>(forms);
      Container = container;
    }

    #endregion

    public override string GetForm()
    {
      return "Rectangle";
    }

    public override FormFactory.Type GetType()
    {
      return FormFactory.Type.Rectangle;
    }

    public override int GetPoid()
    {
      return 0;
    }
  }
}
