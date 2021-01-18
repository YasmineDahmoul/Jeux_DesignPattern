using DesignPatternCL.Actions.Models;
using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Commands
{
    public class ResizeFormCommand : ICommand
    {
        private ResizeAction Resize;

        public ResizeFormCommand(ResizeAction resize)
        {
            this.Resize = resize;
        }

        public void Execute()
        {
            Resize.Resizing();
        }

        public void Cancel()
        {
            Resize.StopResizing();
        }

    }
}
