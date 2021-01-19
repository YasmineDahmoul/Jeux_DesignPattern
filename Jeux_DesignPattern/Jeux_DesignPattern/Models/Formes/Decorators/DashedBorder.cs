using Jeux_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Formes.Decorators
{
    public class DashedBorder : FormeDecorator
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
