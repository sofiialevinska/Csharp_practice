using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace c_sharp_core_ppt9_hw
{
    class Program
    {
        private static void ppt9_hw1()
        {
            List<Shape> shapes = new List<Shape>
            { new Circle("circle1", 3),
            new Square("square4", 2),
            new Circle("circle2", 5),
            new Square("square3", 7),
            new Circle("circle3", 0),
            new Circle("circle4", 23) };

            string writePath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt9_hw/output.txt";

            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("\nShapes with area from range [10,100]:\n");
                var selectedAreaShape =
                    from shape in shapes
                    where ((shape.Area() >= 10) && (shape.Area() <= 100))
                    select shape;

                foreach (var shape in selectedAreaShape)
                {
                    sw.WriteLine(shape.ToString());
                }

                sw.WriteLine("\nShapes which name contains letter 'a':\n");
                var selectLetterA =
                    from shape in shapes
                    where (shape.Name.Contains("a"))
                    select shape;

                foreach (var shape in selectLetterA)
                {
                    sw.WriteLine(shape.Name);
                }
            }

            Console.WriteLine("\nShapes where perimeter is higher than 5:\n");
            var removePerimeter =
                from shape in shapes
                where (shape.Perimeter() > 5)
                select shape;

            shapes = new List<Shape>(removePerimeter);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Name + " " + shape.ToString());
            }
        }

        private static void ppt9_hw2()
        {
            string readPath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt9_hw/big.txt";
            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            Console.WriteLine("\nNumber of symbols in every line from big.txt file:");
            List<int> numSymbolsInLine = new List<int>();
            foreach (string line in lines)
            {
                numSymbolsInLine.Add(line.Length);
                Console.Write(line.Length + " ");
            }

            Console.WriteLine("\nThe longest line from big.txt file:");
            Console.WriteLine(lines[numSymbolsInLine.IndexOf(numSymbolsInLine.Max())]);

            Console.WriteLine("\nThe shortest line from big.txt file:");
            Console.WriteLine(lines[numSymbolsInLine.IndexOf(numSymbolsInLine.Min())]);

            var varLines =
                (from line in lines
                 where (line == "var")
                 select line).ToList();

            Console.WriteLine("\nLines, which consist only of word 'var':");
            Console.WriteLine($"Line number {lines.LastIndexOf("var")} has text 'var'");
            Console.WriteLine($"Line number {lines.IndexOf("var")} has text 'var'");
        }

        static void Main(string[] args)
        {
            //ppt9_hw1();
            ppt9_hw2();
        }
    }
}