using System;
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
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}