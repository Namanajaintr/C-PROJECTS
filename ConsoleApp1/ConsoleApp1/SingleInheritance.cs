using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        //It is the type of inheritance in which there is one base class and one derived class.
        //Parent class
        public class SingleInheritance
    {
            public int length;
            public int breadth;
            public int Area()
            {
                return length * breadth;
            }
            public int Perimeter()
            {
                return 2 * (length + breadth);
            }
        }

        //Child Class
        class Cuboid : SingleInheritance
        {
            public int height;
            public Cuboid(int l, int b, int h)
            {
                length = l;
                breadth = b;
                height = h;
            }
            public int Volume()
            {
                return length * breadth * height;
            }
        }

    
}
