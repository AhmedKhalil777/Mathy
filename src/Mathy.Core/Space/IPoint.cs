using System;
using System.Collections.Generic;
using System.Text;

namespace Mathy.Core
{
    public interface IPoint
    {
        Point2D Reverse(Point2D point, Point2D originReverser);
    }
}
