using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Hw01
{
    class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString()+" (output from derived class)";
        }

        /*
        static void Main(string[] args)
        {
            MyDerivedClass class1 = new MyDerivedClass();
            Console.WriteLine(class1.GetString());
            class1.ContainedString = "Hello";
            Console.WriteLine(class1.GetString());
        }
        */
    }
}
