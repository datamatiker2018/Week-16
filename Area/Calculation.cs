using System;

namespace ConsoleApp1
{
    class Calculation
    {
        // Bad
        public double Area(double width, double height, bool rectangle)
        {
            return width * height;
        }

        public double Area(double radius)
        {
            return Math.PI * radius;
        }

        public double Area(double height, double Base)
        {
            return (height * Base) / 2;
        }
    }
}
