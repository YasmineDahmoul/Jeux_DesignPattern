using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Shapes
{
  public abstract class Forme : IObserver
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public Container Container { get; set; } // (Observator)

    //public System.Windows.Shapes.Shape SystemShape { get; set; } // (WPF Shapes)

    public IAction Action { get; set; } // (Strategie)

    #region Factory abstract methods (Fabrique)

    public abstract string GetForm();

    public abstract new FormeFactory.Type GetType();

    #endregion

    #region Container methods  (Composite)

    public virtual void AddForm(Forme shape)
    {
        
    }

    public virtual void DeleteForm(Forme shape)
    {
     
    }

    #endregion

    public virtual string Details(int depth = 2) => new string('-', depth) + $" {GetForm()}\n";

    #region Observer methods  (Observateur)

    public void Update()
    {
      Action = Container.State();
    }

    #endregion

    public abstract int GetPoid();

  }
}

