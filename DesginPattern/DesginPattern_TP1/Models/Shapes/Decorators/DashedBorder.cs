using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignPatternCL.Models.Shapes.Decorators
{
    public class DashedBorder : FormDecorator
    {
        #region Constractors

        public DashedBorder(Forme Form) : base(Form)
        {

        }

        #endregion

        public int SizeBorder { get; set; } = 2;

        #region Implementation of Shape decorator

        public override int GetPoid()
        {
            return 1 + Form.GetPoid();
        }

        public override string GetForm()
        {
            return Form.GetForm();
        }

        public override FormeFactory.Type GetType()
        {
            return Form.GetType();
        }

        #endregion

    }
}
