using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Shapes
{
  public abstract class FormDecorator : Form
  {
    public Form Form;

    public FormDecorator(Form From)
    {
      this.Form = From;
    }
  }
}
