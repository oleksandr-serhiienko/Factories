using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    public static class PointFactory
    {
        public static Point NewCarhesianPoint(double x, double y) => new Point(x, y);

        public static Point NewPolarPoint (double rho, double theta)=> new Point(rho* Math.Cos(theta), rho* Math.Sin(theta));


    }
}
