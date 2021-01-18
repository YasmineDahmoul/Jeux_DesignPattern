using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignPatternCL.Models.Formes.Decorators
{
    public class DashedBorder : FormDecorator
    {
        public DashedBorder(Forme Form) : base(Form)
        {

        }
        public int SizeBorder { get; set; } = 2;
        public override int GetPoid()
        {
            return 1 + Form.GetPoid();
        }
        public override string GetForme()
        {
            return Form.GetForme();
        }
        public override FormeFactory.Type GetType()
        {
            return Form.GetType();
        }

    }
}
