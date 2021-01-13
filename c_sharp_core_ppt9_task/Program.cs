using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_core_ppt9_task
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 134, -2, 3, 423, 5, 234, 7, 8, 912, -10 };
            var negativeNumbers =
                from number in numbers
                where number < 0
                orderby number
                select number;
            Console.WriteLine("\nAll negative numbers:");
            foreach (var number in negativeNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            var positiveNumbers =
                from number in numbers
                where number >= 0
                orderby number
                select number;
            Console.WriteLine("\nAll positive numbers:");
            foreach (var number in positiveNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();

            Console.WriteLine($"\nThe largest number is {maxNumber}");
            Console.WriteLine($"\nThe smallest number is {minNumber}");

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("\nSum of all elements of the array is {0}", sum);

            Console.WriteLine($"\nFirst largest element in array that is smaller " +
                $"than the Average of elements in array ({(sum / Convert.ToDouble(numbers.Count()))}) " +
                $"is {numbers.FirstOrDefault (n => n>(sum / Convert.ToDouble(numbers.Count())))}");
        }
    }
}
