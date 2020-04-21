using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // is not possible to add the same signature for another values
        // one of the reason to use facotires
        //public Point(double rho, double theta)
        //{

        //}

    }
}
