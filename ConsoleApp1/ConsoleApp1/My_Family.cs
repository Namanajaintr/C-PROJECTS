using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Base class
    public class My_Family
    {
        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class
    public class My_Member : My_Family
    {
        public new void member()
        {

            // Calling the hidden method of the
            // base class in a derived class
            // Using base keyword
            base.member();
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya," +
                                  " Age: 39 \nName: Rohan, Age: 20");
        }
    }         
      
}
