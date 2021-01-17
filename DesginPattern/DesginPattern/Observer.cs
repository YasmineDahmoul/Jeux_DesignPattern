using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern
{
  public class Observer : IObserver
  {

    public string Id { get; set; } = Guid.NewGuid().ToString();

    public void Update()
    {
      Console.WriteLine($"{nameof(Observer)} with Id : {Id}");
    }
  }
}
