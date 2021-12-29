using System;

namespace ProfessionalLesson10Task1
{
    //Реализуйте шаблон NVI в собственной иерархии наследования.
    class BaseClass
    {
        public void NVIMeth()
        {
            First();
            Second();
        }
        protected virtual void First() => Console.WriteLine("First Base");
        protected virtual void Second() => Console.WriteLine("Second Base");
    }

    class DerivedClass : BaseClass
    {
        protected sealed override void First() => Console.WriteLine("First Derived");
        protected sealed override void Second() => Console.WriteLine("Second Derived");
    }


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new DerivedClass();
            bc.NVIMeth();
        }
    }
}
