using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern
{
  public interface ISubject
  {
    void Add(Action observer);
    void Remove(Action observer);
    void Notify();
  }
}
