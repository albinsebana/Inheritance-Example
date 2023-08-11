using InheritancePoc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePoc
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create an instance of the Dog class
            Dog myDog = new Dog();
            myDog.Name = "Puppy";//Dog class inherits the Name property and

            // Inherited method from the base class-->Dog class inherits the Eat()
            myDog.Eat();

            // Method specific to the derived class
            myDog.Bark();
        }
    }
}

//If you don't want other classes to inherit from a class, use the sealed keyword

//sealed class Vehicle 
//{
//    ...
//}
