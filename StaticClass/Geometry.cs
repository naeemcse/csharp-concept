using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Geometry
    {
        public static double pi = 3.1416;

        public static double PlatformID {
            get {
                return pi;
            }
}

public double CallulcaltorAreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CallulcaltorAreaOfRectangle(double width, double height)
        {
            return width * height;
        }
    }
}
