using Jeux_DesignPattern.Interfaces;
using Jeux_DesignPattern.Models;
using Jeux_DesignPattern.Models.Formes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Formes
{
    public class Circle : Forme
    {

        public List<Forme> Formes = new List<Forme>();
        public Circle(IAction action, Container container)
        {
            Container = container;
            Action = action;
        }

        public override void AddForm(Forme shape)
        {
            this.Formes.Add(shape);
        }

        public override void DeleteForm(Forme shape)
        {
            this.Formes.Remove(shape);
        }

        public override string GetChildren(int count = 1)
        {
            string result = new string('*', count) + " " + GetForme() + "\n";
            foreach (var forme in Formes)
                result += forme.GetChildren(count + 1);
            return result;
        }

        public override int GetPoid()
        {
            return 0;
        }

        public override string GetForme()
        {
            return "Circle";
        }

        public override FormeFactory.Type GetType()
        {
            return FormeFactory.Type.Circle;
        }
    }
}
