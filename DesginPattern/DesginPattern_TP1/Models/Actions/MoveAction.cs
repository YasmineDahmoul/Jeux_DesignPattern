using DesignPatternCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCL.Actions.Models
{
    public class MoveAction : IAction
    {
        public void ActionForme()
        {

        }

        public string GetAction()
        {
            return "Move";
        }

        public void MoveUp()
        {
            Console.WriteLine("Move up");
        }

        public void StopMoving()
        {
            Console.WriteLine("stop moving");

        }

    }
}
