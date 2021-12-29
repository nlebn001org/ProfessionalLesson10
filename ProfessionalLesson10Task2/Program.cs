using System;

namespace ProfessionalLesson10Task2
{
    //    Задание 2
    //Выучите описание шаблона Template method(Шаблонный метод). Обратите внимание на
    //применимость шаблона, а также на состав его участников и связи отношения между ними.
    //Напишите небольшую программу на языке C#, представляющую собой абстрактную
    //реализацию данного шаблона.

    abstract class Programmer
    {
        public void Cycle(int? meth, bool all)
        {
            if (all == true)
            {
                DoWork();
                DoHobby();
                GetSalary();
                return;
            }
            switch (meth)
            {
                case null:
                    break;
                case 1:
                    DoWork();
                    break;
                case 2:
                    DoHobby();
                    break;
                case 3:
                    GetSalary();
                    break;
                default:
                    break;
            }
        }
        protected abstract void DoWork();
        protected abstract void DoHobby();
        protected abstract void GetSalary();

    }

    class CSProgrammer : Programmer
    {
        protected override void DoHobby() => Console.WriteLine("DO C# hobby");
        protected override void DoWork() => Console.WriteLine("DO C# Work");
        protected override void GetSalary() => Console.WriteLine("Get C# Salary");
        protected void BuySmth() => Console.WriteLine("Buy Smth");
    }

    class JSPropgrammer : Programmer
    {
        protected override void DoHobby() => Console.WriteLine("DO JS hobby");
        protected override void DoWork() => Console.WriteLine("DO JS Work");
        protected override void GetSalary() => Console.WriteLine("Get JS Salary");
        protected void PlayGame() => Console.WriteLine("Play GAMe");

    }

    class Program
    {
        static void Main(string[] args)
        {
            Programmer js = new JSPropgrammer();
            Programmer cs = new JSPropgrammer();
            Console.WriteLine($"JS Sycle");
            js.Cycle(1, false);
            Console.WriteLine("\n\n");
            Console.WriteLine($"CS Sycle");
            cs.Cycle(1, true);
            Console.WriteLine("\n\n");

        }
    }
}
