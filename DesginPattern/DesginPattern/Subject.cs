using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern
{
  public class Subject : ISubject
  {

    public List<Action> Observers { get; set; } = new List<Action>();



    public void Add(Action observer)
    {
      Observers.Add(observer);
    }

    public void Notify()
    {
      foreach (var ob in Observers)
        ob.Invoke();
    }

    public void Remove(Action observer)
    {
      Observers.Remove(observer);
    }
  }
}
