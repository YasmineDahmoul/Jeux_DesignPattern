using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Formes
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
