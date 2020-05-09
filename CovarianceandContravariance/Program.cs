using System;

namespace CovarianceandContravariance
{

    public class Animal
    {
        public void Eat() => Console.WriteLine("Eat");
    }
    public class Bird : Animal
    {
        public void Fly() => Console.WriteLine("Fly");
    }

    public delegate Animal GetAnimalDelegate();
    public delegate Bird GetBirdDelegate();

    public delegate void TakeAnimalDelegate(Animal a);
    public delegate void TakeBirdDelegate(Bird b);


    class Program
    {
        static void Main(string[] args)
        {
            static Animal GetAnimal() => new Animal();
            static Bird GetBird() => new Bird();

            static void Eat(Animal animal) => animal.Eat();
            static void Fly(Bird bird) => bird.Fly();

            GetAnimalDelegate del = GetBird;
            del();

            TakeBirdDelegate del1 = Eat;
            del1(new Bird());

            //TakeAnimalDelegate del2 = Fly; // Does not work
            //del1(new Bird());


            Console.ReadLine();
        }
    }
}
