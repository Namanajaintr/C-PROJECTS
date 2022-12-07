using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //An interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies) :
    //To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class.
    //To implement an interface, use the : symbol (just like with inheritance). The body of the interface method is provided by the "implement" class.
    //Note that you do not have to use the override keyword when implementing an interface:
    interface Interface
    {
        abstract void myMethod(); // interface method

    }

    interface Interface2
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : Interface, Interface2
    {
        public void myMethod()
        {
            Console.WriteLine("Some text in abstract method ");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

}
