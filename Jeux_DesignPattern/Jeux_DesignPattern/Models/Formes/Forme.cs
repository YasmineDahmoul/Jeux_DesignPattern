using Jeux_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Formes
{
    public abstract class Forme : IObserver
    {
        public Container Container { get; set; }

        public IAction Action { get; set; }

        public abstract string GetForme();

        public abstract new FormeFactory.Type GetType();
        public virtual void AddForm(Forme shape)
        {

        }
        public virtual void DeleteForm(Forme shape)
        {

        }
        public virtual string GetChildren(int count = 1)
        {
            return new string('*', count) + " " + GetForme() + "\n";
        }
        public void Update()
        {
            Action = Container.State();
        }
        public abstract int GetPoid();

    }
}

