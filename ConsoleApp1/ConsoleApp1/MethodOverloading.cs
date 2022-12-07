using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MethodOverloading
    {
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }
    class MethodOverloading2
    {
        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        // adding three double values.
        public double Add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }

    }

    class MethodOverloading3
    {
        // Method
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", "
                            + "Id1 : " + id);
        }

        // Method
        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "
                            + "Id2 : " + id);
        }
    }
}
