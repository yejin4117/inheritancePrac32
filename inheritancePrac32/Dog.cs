using System;

namespace InheritancePrac32
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }
    }
}