using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    public class AnimalCollection : CollectionBase
    {
        public void Add(Animal newAnimal) =>
            List.Add(newAnimal);

        public void Remove(Animal newAnimal) =>
            List.Remove(newAnimal);

        public Animal this[int animalIdex]
        {
            get { return (Animal)List[animalIdex]; }

            set { List[animalIdex] = value; }
        }
    }
}
