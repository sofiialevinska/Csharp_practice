using System;
namespace c_sharp_core_ppt8_hw
{
    public abstract class Shape : IComparable
    {
        private string name;
        protected string Name { get { return name; } }
        public Shape()
        {
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(object obj)
        {
            Shape sh = obj as Shape;
            if (sh != null)
                return Area().CompareTo(sh.Area());
            else
                throw new ArgumentException("Object is not Shape");
        }

    }
}
