using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    public class Point
    {
        public enum CoordinateSystem
        {
            Cartesian,
            Polar
        }

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double a, double b, 
            CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            (X, Y) = system switch 
            {
                CoordinateSystem.Cartesian => (a, b),
                CoordinateSystem.Polar => (a*Math.Cos(b), a*Math.Sin(b)),
                _=> throw new ArgumentNullException()
            };
        }

        // is not possible to add the same signature for another values
        // one of the reason to use facotires
        //public Point(double rho, double theta)
        //{

        //}

    }
}
