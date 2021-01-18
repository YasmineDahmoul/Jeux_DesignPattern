using DesignPatternCL.Interfaces;
using DesignPatternCL.Models.Formes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Formes
{
    public class FormeFactory
    {
        public enum Type
        {
            Rectangle,
            Circle,
            Triangle
        }

        private FormeFactory() { }

        public static Forme Create(Type shapeType, IAction action, Container container)
        {
            switch (shapeType)
            {
                case Type.Circle:
                    return new Circle(action, container);
                case Type.Rectangle:
                    return new Rectangle(action, container);
                case Type.Triangle:
                    return new Triangle(action, container);

                default: return new Circle(action, container);
            }
        }

    }
}
