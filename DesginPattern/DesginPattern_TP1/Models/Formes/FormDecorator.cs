using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Formes
{
    public abstract class FormDecorator : Forme
    {
        public Forme Form;

        public FormDecorator(Forme From)
        {
            this.Form = From;
        }
    }
}
