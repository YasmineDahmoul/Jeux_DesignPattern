using Jeux_DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_DesignPattern.Actions.Models
{
    public class ResizeAction : IAction
    {
        public void ActionForme()
        {
        }

        public string GetAction()
        {
            return "Resize";
        }

        public void Resizing()
        {
            Console.WriteLine("Resizing..");
        }

        public void StopResizing()
        {
            Console.WriteLine("Stop Resizing!");
        }

    }
}
