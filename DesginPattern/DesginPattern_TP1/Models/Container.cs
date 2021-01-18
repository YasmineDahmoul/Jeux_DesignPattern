using DesignPatternCL.Actions;
using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models
{
    public class Container : ISubject
    {

        private List<IObserver> Formes = new List<IObserver>();

        public IAction Action;


        public Container() { }

        public Container(IAction action)
        {
            Action = action;
        }

        public void Notification()
        {
            foreach (var forme in Formes)
                forme.Update();
        }

        public void Subscribe(IObserver forme)
        {
            Formes.Add(forme);
        }

        public void Unsubscribe(IObserver forme)
        {
            Formes.Remove(forme);
        }

        public IAction State()
        {
            return Action;
        }

    }
}
