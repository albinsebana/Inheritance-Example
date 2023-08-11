using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritancePoc.Model
{
    internal class Animal
    {
        public string Name { get ; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Derived class (subclass)
    class Dog : Animal//Dog is inheriting from the class Animal
    {
        public void Bark()//Dog class can define its own unique properties and methods.
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

}

