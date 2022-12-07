using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   
        // Abstract class
        abstract class AbstractionClass
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("sleep Zzz from abstract class");
            }
        }

        // Derived class (inherit from Animal)
         class Pig : AbstractionClass
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee imp of abstract class in normal class");
            }
        }

 }

