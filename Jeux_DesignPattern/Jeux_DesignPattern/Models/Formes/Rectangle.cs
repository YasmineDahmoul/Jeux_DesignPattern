using Jeux_DesignPattern.Interfaces;
using Jeux_DesignPattern.Models;
using Jeux_DesignPattern.Models.Formes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Formes
{
    public class Rectangle : Forme
    {
        public List<Forme> Formes = new List<Forme>();


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



        public Rectangle(IAction action, Container container)
        {
            Container = container;
            Action = action;
        }

        public Rectangle(IAction action, List<Forme> forms, Container container)
        {
            Action = action;
            Formes = new List<Forme>(forms);
            Container = container;
        }


        public override string GetForme()
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
