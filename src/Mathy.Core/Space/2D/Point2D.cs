using System;
using System.Collections.Generic;
using System.Text;

namespace Mathy.Core
{
    public struct Point2D : IEquatable<Point2D>, IComparable<Point2D>, IPoint
    {
        public static readonly Point2D Default = new Point2D(0,0);
        public static readonly Point2D Origin = new Point2D(0,0);

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public int CompareTo(Point2D other)
        {
            return X.CompareTo(other.X) + Y.CompareTo(other.Y);
        }

        public bool Equals(Point2D other)
        {
            return X == other.X && Y == other.Y;
        }

        public Point2D Reverse(Point2D reverser)
        {
            return new Point2D( 2 *reverser.X - X, 2 * reverser.Y - Y);
        }
    }
}
