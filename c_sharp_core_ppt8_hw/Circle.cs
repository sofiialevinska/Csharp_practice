using System;
namespace c_sharp_core_ppt8_hw
{
    public class Circle : Shape
    {
        private double radius;
        private static readonly double PI = 3.14;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * PI * radius;
        }

        public override string ToString()
        {
            return $"Area is {Area():f2}, Perimeter is {Perimeter():f2}";
        }
    }
}
