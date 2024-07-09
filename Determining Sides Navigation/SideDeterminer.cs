using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determining_Sides_Navigation;

public static class SideDeterminer
{
    public static string DetermineCoordinatePosition(Coordinates lineStart, Coordinates lineEnd, Coordinates pointToDetermine)
    {
        double crossProduct = (lineEnd.X - lineStart.X) * (pointToDetermine.Y - lineStart.Y) - (lineEnd.Y - lineStart.Y) * (pointToDetermine.X - lineStart.X);

        return crossProduct switch
        {
            > 0 => "the left from",
            < 0 => "the right from",
            _ => "top of"
        };
    }
}
