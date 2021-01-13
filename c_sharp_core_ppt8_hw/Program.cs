using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_core_ppt8_hw
{
    class Program
    {
        private static void PrintAll(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("circle1", 3));
            shapes.Add(new Square("square4", 2));
            shapes.Add(new Circle("circle2", 5));
            shapes.Add(new Square("square3", 7));
            shapes.Add(new Circle("circle3", 0));
            shapes.Add(new Circle("circle4", 23));
            shapes.Add(new Square("square1", 1));
            shapes.Add(new Square("square2", 14));

            //Print all shapes areas and perimeters in list
            Console.WriteLine("\nAll shapes areas and perimeters in list:");
            PrintAll(shapes);

            //Find shape with the largest perimeter and print its name
            double maxPerimeter = 0;
            int index = 0;
            foreach (Shape shape in shapes)
            {
                if (shape.Perimeter() > maxPerimeter)
                {
                    maxPerimeter = shape.Perimeter();
                    index = shapes.IndexOf(shape);
                }
            }
            Console.WriteLine("\nShape with the largest perimeter in list:");
            Console.WriteLine(shapes[index].ToString());

            //Sort shapes by area and print obtained list (Remember about IComparable)
            shapes.Sort();

            //Print all shapes areas and perimeters in list
            Console.WriteLine("\nAll shapes areas and perimeters in list:");
            PrintAll(shapes);
        }
    }
}
