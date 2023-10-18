using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Hw
{
    public class Person:ICloneable
    {
        private string name;
        private int age;

        public object Clone()
        {
            Person newPerson = new Person();
            newPerson.Age = Age;
            newPerson.Name = Name;
            return newPerson;
        }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static bool operator >(Person p1, Person p2) => p1.Age > p2.Age;

        public static bool operator <(Person p1, Person p2) => p1.Age < p2.Age;

        public static bool operator >=(Person p1, Person p2) => !(p1.Age < p2.Age);

        public static bool operator <=(Person p1, Person p2) => !(p1.Age > p2.Age);


        //public static bool operator ==(Person p1, Person p2) => (p1.Age == p2.Age);

        //public static bool operator !=(Person p1, Person p2) => (p1.Age != p2.Age);



    }
}
