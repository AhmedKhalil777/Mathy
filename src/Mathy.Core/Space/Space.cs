using System;
using System.Collections.Generic;
using System.Text;

namespace Mathy.Core.Space
{
    public static class Space 
    {
        public static Point2D CreatePoint2D(double x, double y) => new Point2D() { X = x, Y = y };
        
    }
}
