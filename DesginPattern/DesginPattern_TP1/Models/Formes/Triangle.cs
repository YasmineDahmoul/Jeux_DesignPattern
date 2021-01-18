using DesignPatternCL.Interfaces;
using DesignPatternCL.Models;
using DesignPatternCL.Models.Formes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Formes
{
    public class Triangle : Forme
    {

        public List<Forme> Formes = new List<Forme>();


        public Triangle(IAction action, Container container)
        {
            Container = container;
            Action = action;
        }

        public override int GetPoid()
        {
            return 0;
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

        public override string GetForme()
        {
            return "Triangle";
        }

        public override FormeFactory.Type GetType()
        {
            return FormeFactory.Type.Triangle;
        }
    }
}
