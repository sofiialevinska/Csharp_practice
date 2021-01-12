using System;
namespace c_sharp_core_ppt8_hw
{
    public class Square: Shape
    {
        private double side;
        public Square (string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public override string ToString()
        {
            return $"Area is {Area():f2}, Perimeter is {Perimeter():f2}";
        }
    }
}
