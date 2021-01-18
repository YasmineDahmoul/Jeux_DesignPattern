using DesignPatternCL.Actions.Models;
using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Models.Commands
{
    class MovingFormCommand : ICommand
    {

        private MoveAction MoveAction;

        public MovingFormCommand(MoveAction moveAction)
        {
            MoveAction = moveAction;
        }
        public void Execute()
        {
            MoveAction.MoveUp();
        }

        public void Cancel()
        {
            MoveAction.StopMoving();
        }
       
    }
}
