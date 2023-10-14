﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalCollection animalCollection = new AnimalCollection();

            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Marry"));
            foreach(Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();
        }
    }
}
