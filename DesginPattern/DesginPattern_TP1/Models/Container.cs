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

    private List<IObserver> Forms = new List<IObserver>();

    public IAction Action;

    #region Constractors

    public Container() { }

    public Container(IAction _action) 
    {
      Action = _action;
    }

    #endregion

    public void Notification()
    {
      foreach (var form in Forms)
        form.Update();
    }

    public void Subscribe(IObserver shape)
    {
      Forms.Add(shape);
    }

    public void Unsubscribe(IObserver shape)
    {
      Forms.Remove(shape);
    }

    public IAction State()
    {
      return Action;
    }

  }
}
