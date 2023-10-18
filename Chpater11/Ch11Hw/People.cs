using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Hw
{
    public class People : DictionaryBase, ICloneable
    {
        public object Clone()
        {
            People clonedPeople = new People();
            Person currentPerson, newPerson;

            foreach (DictionaryEntry p in Dictionary)
            {
                currentPerson = p.Value as Person;
                newPerson = currentPerson.Clone() as Person;
                clonedPeople.Add(newPerson);
            }
            return clonedPeople;
        }

        // 定义可迭代属性Ages
        public IEnumerable Ages
        {
            get 
            {
                foreach(object aPerson in Dictionary.Values)
                {
                    yield return (aPerson as Person).Age;
                }
            }
        }

        public void Add(Person person)
        {
            Dictionary.Add(person.Name, person);
        }

        public void Remove(string name)
        {
            Dictionary.Remove(name);
        }

        public Person this[string name]
        {
            get { return (Person)Dictionary[name]; }
            set { Dictionary[name] = value; }
        }

        public Person[] GetOldest()
        {
            Person oldestPerson = null;

            People oldestPeople = new People();

            Person currentPerson;

            foreach (DictionaryEntry p in Dictionary)
            {
                currentPerson = p.Value as Person;
                if (oldestPerson == null)
                {
                    oldestPerson = currentPerson;
                    oldestPeople.Add(oldestPerson);
                }
                else
                {
                    if (currentPerson > oldestPerson)
                    {
                        oldestPeople.Clear();
                        oldestPeople.Add(currentPerson);
                        oldestPerson = currentPerson;
                    }
                    else
                    {
                        // not great but geq, so equal
                        if (currentPerson >= oldestPerson)
                        {
                            oldestPeople.Add(currentPerson);
                        }
                    }
                }
            }

            Person[] oldestPeopleArray = new Person[oldestPeople.Count];
            int copyIndex = 0;

            foreach (DictionaryEntry p in oldestPeople)
            {
                oldestPeopleArray[copyIndex] = p.Value as Person;
                copyIndex++;
            }

            return oldestPeopleArray;

        }
    }
}
