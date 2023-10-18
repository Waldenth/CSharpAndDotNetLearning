using System;

namespace Ch11Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] ps = new Person[10];
            People people = new People();
            string defaultName = "No.";
            for (int i = 0; i < 10; i++)
            {
                string name = i.ToString();
                ps[i] = new Person(defaultName+name,i);
                people.Add(ps[i]);
            }

            foreach (int age in people.Ages)
            {
                Console.WriteLine($"age={age}");
            }
        }
    }
}
