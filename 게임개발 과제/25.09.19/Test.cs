using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    interface IDog
    {
        void Eat();
    }

    interface ICat
    {
        void Eat();
    }

    class Pet : IDog, ICat
    {
        void IDog.Eat() => Console.WriteLine("Dog Eat");
        void ICat.Eat() => Console.WriteLine("Cat Eat");
    }

    internal class Test
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            ((IDog)pet).Eat();
            ((ICat)pet).Eat();

            IDog dog = new Pet();
            ICat cat = new Pet();

            dog.Eat();
            cat.Eat();
        }
    }
}
