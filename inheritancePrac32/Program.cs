﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InheritancePrac32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Public();
            //dog.Protected();
            //dog.Private();

            List<Animal> Animals = new List<Animal>() { new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat() };
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                var _dog = item as Dog;
                if (_dog != null) { _dog.Bark(); }

                var _cat = item as Cat;
                if (_cat != null) { _cat.Meow(); }

                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }
                else if (item is Cat)
                {
                    ((Cat)item).Meow();
                }
            }
        }
    }
}