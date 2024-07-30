using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Animal dog = new Dog();
            dog.Sound();
           
        }
    }
    class Animal
    {
       public virtual void Sound()
        {
            Console.WriteLine("Makes some sound");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("meow meow");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bow Bow");
            Console.ReadLine();
        }
    }

}
