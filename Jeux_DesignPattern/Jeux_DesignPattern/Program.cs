using Jeux_DesignPattern.Actions;
using Jeux_DesignPattern.Interfaces;
using Jeux_DesignPattern.Models;
using Jeux_DesignPattern.Models.Formes;
using Jeux_DesignPattern.Models.Formes.Decorators;
using System;
using System.Collections.Generic;

namespace Jeux_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // ====> Faactory & Strategy 

            IAction Move = ActionFactory.Create(ActionFactory.ActionType.Move);
            IAction Notification = ActionFactory.Create(ActionFactory.ActionType.Notification);
            IAction Resize = ActionFactory.Create(ActionFactory.ActionType.Resize);

            List<Forme> formes = new List<Forme>();
            Container c = new Container();
            formes.Add(FormeFactory.Create(FormeFactory.Type.Rectangle, Move, c));
            formes.Add(FormeFactory.Create(FormeFactory.Type.Circle, Notification, c));
            formes.Add(FormeFactory.Create(FormeFactory.Type.Triangle, Resize, c));

            foreach (var form in formes)
            {
                Console.WriteLine();
                Console.WriteLine("  * form : " + form.GetForme() + " ===>  " + form.Action.GetAction());
            }
            //******************************************************************
            //  ====> Observateur


            Container container = new Container(ActionFactory.Create(ActionFactory.ActionType.Resize));

            Forme rectangle = FormeFactory.Create(FormeFactory.Type.Rectangle, ActionFactory.Create(ActionFactory.ActionType.Resize), container);
            Forme circle = FormeFactory.Create(FormeFactory.Type.Circle, ActionFactory.Create(ActionFactory.ActionType.Notification), container);
            Forme triangle = FormeFactory.Create(FormeFactory.Type.Triangle, ActionFactory.Create(ActionFactory.ActionType.Move), container);

            Console.WriteLine(rectangle.GetForme() + " - " + rectangle.Action.GetAction());
            Console.WriteLine(circle.GetForme() + " -" + circle.Action.GetAction());
            Console.WriteLine(triangle.GetForme() + " - " + triangle.Action.GetAction());

            Console.WriteLine();
            Console.WriteLine("========= Subscribe rectangle && Triangle && circle");
            Console.WriteLine();

            container.Subscribe(rectangle);
            container.Subscribe(circle);
            container.Subscribe(triangle);
            container.Notification();
            Console.WriteLine(rectangle.GetForme() + " - " + rectangle.Action.GetAction());
            Console.WriteLine(circle.GetForme() + " - " + circle.Action.GetAction());
            Console.WriteLine(triangle.GetForme() + " - " + triangle.Action.GetAction());

            Console.WriteLine();
            Console.WriteLine("========= Unsubscribe rectangle && triangle");
            Console.WriteLine();

            container.Unsubscribe(rectangle);
            container.Unsubscribe(triangle);
            container.Action = ActionFactory.Create(ActionFactory.ActionType.Resize);
            container.Notification();
            Console.WriteLine(rectangle.GetForme() + " - " + rectangle.Action.GetAction());
            Console.WriteLine(circle.GetForme() + " - " + circle.Action.GetAction());
            Console.WriteLine(triangle.GetForme() + " - " + triangle.Action.GetAction());


            //**************************************

            Forme rect = FormeFactory.Create(FormeFactory.Type.Rectangle, ActionFactory.Create(ActionFactory.ActionType.Notification), new Container());

            Forme c1 = new DashedBorder(rect);
            Forme r1 = new DashedBorder(c1);
            r1 = FormeFactory.Create(FormeFactory.Type.Circle, ActionFactory.Create(ActionFactory.ActionType.Resize), new Container());
            Forme r2 = new DashedBorder(r1);
            r1 = new DashedBorder(r1);
            r1 = new SolidBorder(r1);
            Console.WriteLine(rect.GetForme() + " - " + rect.GetPoid());
            Console.WriteLine(c1.GetForme() + " - " + c1.GetChildren());

            c1 = new SolidBorder(c1);

            Console.WriteLine(r1.GetForme() + " - " + r1.GetPoid());
            Console.WriteLine(c1.GetForme() + " - " + c1.GetChildren());


            Console.ReadKey();
        }
    }
}
