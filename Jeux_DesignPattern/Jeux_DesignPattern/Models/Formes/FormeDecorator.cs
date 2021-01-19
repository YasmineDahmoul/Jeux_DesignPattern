using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Models.Formes
{
    public abstract class FormeDecorator : Forme
    {
        public Forme Form;

        public FormeDecorator(Forme From)
        {
            this.Form = From;
        }
    }
}
