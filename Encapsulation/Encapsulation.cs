using System;

namespace Encapsulation
{
    class EncapsulationClass
    {
        public int data {get;/*set;*/} //this is shortcut way for get set in c#, can defined set class 
        protected string data2;
        private float data3;
        public EncapsulationClass()
        {
            data=75;
        }
        public float Data3
        {
            get
            {
            return data3;
            }
            set
            {
            data3=value;
            }
        }

    }
    class EncapsulationClassInherit:EncapsulationClass
    {
        public string Data2
        {
            get
            {
                return data2;
            }
            set
            {
                data2=value;
            }
        }
    }
    class Encapsulation
    {
        static void Main(string[] args)
        {
            var obj=new EncapsulationClass();
            //obj.data3 this command is illegal, can only access with public set or get methods.
            obj.Data3=5.5f;
            Console.WriteLine("Data 3: " + obj.Data3);
            //obj.data2 this illegal command, can only access after create public set or get methods in base class or with subclass public set or get methods.
            var obj2=new EncapsulationClassInherit();
            obj2.Data2="Test Data";
            Console.WriteLine("Data 2: "+obj2.Data2);
            //also can access data with setter and getter
            //obj2.data=5; this is illegal, set methods not defined in class.
            Console.WriteLine("Data : "+obj.data);            
            
        }
    }
}
