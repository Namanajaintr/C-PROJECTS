using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Constructor
    {
        public int id;
        public string name;

        //user defined constructor then default constructor will not be there

        public Constructor(string a)
        {
            name = a;
            Console.WriteLine("Execution  from Base Class");
        }
        public Constructor(string b,int a)
        {
            name = b;
            id = a;
        }
    }
    class Constructor2 : Constructor
    {
        public double color;
        public float width;
        public string style;

        //base refers to parent constructor
        public Constructor2(string x, double y,int p): base(x,p)
        {
            color = y;
            Console.WriteLine("Execution  from Derived Class");

        }
        //this refers to current constructor
        //public Constructor2(string s, float w , double c ) : this(w,c)
        //{
        //    style = s;
        //}

    }


}
