using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{

    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }

    public class Point
    {
        // factory method design
        public static Point NewCaresainPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        public double X { get; set; }
        public double Y { get; set; }

        private Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X : {X} Y: {Y}";
        }
    }
}
