using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog();
            dog.Name = "Buddy";
            Console.WriteLine("Dog method is activating");
            Console.ReadLine();
            dog.Bark();

            
            Cat cat = new Cat();
            cat.Name = "Whiskers";
            Console.WriteLine("Cat method is activating");
            Console.ReadLine();
            cat.Meow();
        }
    }

    // Base class
    class Animal
    {
        public string Name { get; set; }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(Name + " says Bow!");
            Console.ReadLine();
        }
    }

    // Derived class
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine(Name + " says Meow!");
            Console.ReadLine();
        }
    }
}
