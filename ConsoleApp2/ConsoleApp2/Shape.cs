using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Shape
    {
        public double C;
        public double A;
        public double P;
        public double CircumferenceOfCircle(double r)
        {
            C = 2 * 3.142 * r;
            return C;
        }

        public double AreaOfTriangle(double h, double b)
        {
            A = h * b / 2;
            return A;
        }

        public double PerimeterOfRectangle(double l, double w)
        {
            P = 2 * (l + w);
            return P;
        }
    }
}
