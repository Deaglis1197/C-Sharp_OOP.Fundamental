using System;

namespace Abstraction
{
    abstract class AbstractClass
    {
        protected int _data;
        public abstract void method();
    }
    class SubClass : AbstractClass
    {
        public SubClass(int data)
        {
            _data=data;
        }
        public override void method()
        {
            Console.WriteLine("Data : "+ _data);
        }
    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            //var obj=new AbstractClass();
            //obj.method(); this is illegal, cant create new object from any Abstract, can only create Subclass of Abstract
            var obj=new SubClass(5);
            obj.method();
        }
    }
}
