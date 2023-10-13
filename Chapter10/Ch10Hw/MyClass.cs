using System;

namespace Ch10Hw01
{
    class MyClass
    {
        protected string myString="Null";
        
        public string ContainedString
        {
            set
            {
                myString = value;
            }
        }

        public virtual string GetString() => myString;

     
        /*
        static void Main(string[] args)
        {
            MyClass class1 = new MyClass();
            Console.WriteLine(class1.GetString());
            class1.ContainedString = "Hello";
            Console.WriteLine(class1.GetString());
        }
        */
    }
}
