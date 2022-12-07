using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1

   // Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
   // Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks.
   // This allows us to perform a single action in different ways.
{
        public class Polymorphism  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

         class Cat : Polymorphism  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Polymorphism  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

    
}
