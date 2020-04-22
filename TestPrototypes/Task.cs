using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrototypes
{

    public interface IPrototype<T>
    {
        T DeepCopy();
    }

    public class Point : IPrototype<Point>
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        { 
        }

        public Point DeepCopy()
        {
            return new Point(X, Y);
        }
    }

    public class Line : IPrototype<Line>
    {
        public Point Start, End;

        public Line()
        { 
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            return new Line(Start.DeepCopy(), End.DeepCopy());
        }

        public override string ToString()
        {
            return $"Start Point: {Start.X}, {Start.Y}. End Point: {End.X}, {End.Y}";
        }
    }
}
