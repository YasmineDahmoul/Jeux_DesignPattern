using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DesignPatternCL.Models.Shapes.Decorators
{
  public class SolidBorder : FormDecorator
  {

    #region Constractors

    public SolidBorder(Form Form) : base(Form)
    {

    }

        #endregion

        public int Size { get; set; } = 2;

    #region Implementation of Shape decorator

    public override int GetPoid()
    {
      return 1 + Form.GetPoid();
    }

    public override string GetForm()
    {
      return Form.GetForm();
    }

    public override FormFactory.Type GetType()
    {
      return Form.GetType();
    }

    #endregion
  }
}
