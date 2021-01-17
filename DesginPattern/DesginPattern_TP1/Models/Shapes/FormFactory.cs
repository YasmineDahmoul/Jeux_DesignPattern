using DesginPattern_TP1.Models.Shapes;
using DesignPatternCL.Interfaces;
using DesignPatternCL.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models
{
  public class FormFactory
  {
    public enum Type
    {
      Rectangle,
      Circle,
      Square
    }

    private FormFactory() { }

    public static Form Create(Type shapeType, IAction action, Container container)
    {
      switch (shapeType)
      {
        case Type.Circle:
          return new Circle(action, container);
        case Type.Rectangle:
          return new Rectangle(action, container);
        case Type.Square:
          return new Square(action, container);
       
        default: return new Circle(action, container);
      }
    }
    
  }
}
