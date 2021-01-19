using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Interfaces
{
  public interface ICommand
  {
    void Execute();
    void Cancel();
  }
}
