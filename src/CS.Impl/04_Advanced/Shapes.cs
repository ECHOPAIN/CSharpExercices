using System;

namespace CS.Impl._04_Advanced
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class Circle : Shape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.Floor(Math.PI * (radius * radius));
        }

        public override double GetPerimeter()
        {
            return Math.Floor(2 * Math.PI * radius);
        }
    }

    public class Rectangle : Shape
    {
        double length;
        double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override double GetPerimeter()
        {
            return 2 * length + 2 * width;
        }
    }

    public class Square : Shape
    {
        double sideLength;
        public Square(double sideLength)
        {
            this.sideLength=sideLength;
        }

        public override double GetArea()
        {
            return sideLength * sideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * sideLength;
        }
    }
}