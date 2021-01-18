using DesignPatternCL.Actions;
using DesignPatternCL.Actions.Models;
using DesignPatternCL.Interfaces;
using DesignPatternCL.Models;
using DesignPatternCL.Models.Actions;
using DesignPatternCL.Models.Shapes;
using DesignPatternCL.Models.Shapes.Decorators;
using DesignPatternCL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPattern
{
  class Program
  {
    static void Main(string[] args)
    {
            //// TP1 ===> Singleton
            //LogRepository logRepository = new LogRepository();

            //for (int i = 0; i < 100; i++)
            //{
            //    logRepository.Insert(new Log()
            //    {
            //        Session = $"User {i}",
            //        Object = $"Object {i}",
            //        Action = $"Action {i}"
            //    });

            //}

            //var l = logRepository.Get();

            //Console.ReadKey();
            ////**************************************************************************

            ////TP2 ====> Faactory & Strategy 


            //IAction Move = ActionFactory.Create(ActionFactory.ActionType.Move);
            //IAction Notification = ActionFactory.Create(ActionFactory.ActionType.Notification);
            //IAction Resize = ActionFactory.Create(ActionFactory.ActionType.Resize);

            //List<Form> forms = new List<Form>();
            //Container  c = new Container();
            //forms.Add(FormFactory.Create(FormFactory.Type.Rectangle, Move, c));
            //forms.Add(FormFactory.Create(FormFactory.Type.Circle, Notification, c));
            //forms.Add(FormFactory.Create(FormFactory.Type.Square, Resize, c));

            //foreach (var form in forms)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"  * form : {form.GetForm()} ===>  {form.Action.GetAction()}");
            //}
            ////******************************************************************
            //// TP4 ====> Observateur


            //Container container = new Container(ActionFactory.Create(ActionFactory.ActionType.Resize));

            //Form rectangle = FormFactory.Create(FormFactory.Type.Rectangle, ActionFactory.Create(ActionFactory.ActionType.Resize), container);
            //Form circle = FormFactory.Create(FormFactory.Type.Circle, ActionFactory.Create(ActionFactory.ActionType.Notification), container);
            //Form square = FormFactory.Create(FormFactory.Type.Square, ActionFactory.Create(ActionFactory.ActionType.Move), container);

            //Console.WriteLine($" {rectangle.GetForm()} - {rectangle.Action.GetAction()}");
            //Console.WriteLine($" {circle.GetForm()} - {circle.Action.GetAction()}");
            //Console.WriteLine($" {square.GetForm()} - {square.Action.GetAction()}");

            //Console.WriteLine();
            //Console.WriteLine("========= Subscribe rectangle && square && ellipse");
            //Console.WriteLine();

            //container.Subscribe(rectangle);
            //container.Subscribe(circle);
            //container.Subscribe(square);
            //container.Notification();
            //Console.WriteLine($" {rectangle.GetForm()} - {rectangle.Action.GetAction()}");
            //Console.WriteLine($" {circle.GetForm()} - {circle.Action.GetAction()}");
            //Console.WriteLine($" {square.GetForm()} - {square.Action.GetAction()}");

            //Console.WriteLine();
            //Console.WriteLine("========= Unsubscribe rectangle && square");
            //Console.WriteLine();

            //container.Unsubscribe(rectangle);
            //container.Unsubscribe(square);
            //container.Action = ActionFactory.Create(ActionFactory.ActionType.Resize);
            //container.Notification();
            //Console.WriteLine($" {rectangle.GetForm()} - {rectangle.Action.GetAction()}");
            //Console.WriteLine($" {circle.GetForm()} - {circle.Action.GetAction()}");
            //Console.WriteLine($" {square.GetForm()} - {square.Action.GetAction()}");


            //**************************************

            Forme rectangle = FormeFactory.Create(FormeFactory.Type.Rectangle, ActionFactory.Create(ActionFactory.ActionType.Notification), new Container());

            Forme c = new DashedBorder(rectangle);
            Forme r1 = new DashedBorder(c);
            r1 = FormeFactory.Create(FormeFactory.Type.Circle, ActionFactory.Create(ActionFactory.ActionType.Resize), new Container());
            Forme r2 = new DashedBorder(r1);
            r1 = new DashedBorder(r1);
            r1 = new SolidBorder(r1);
            Console.WriteLine($"{rectangle.GetForm()} - {rectangle.GetPoid()}");
            Console.WriteLine($"{c.GetForm()} - {c.GetPoid()}");

            c = new SolidBorder(c);

            Console.WriteLine($"{r1.GetForm()} - {r1.GetPoid()}");
            Console.WriteLine($"{c.GetForm()} - {c.GetPoid()}");


            Console.ReadKey();
    }
  }
}
