using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_core_ppt5_hw
{
    class Program
    {
        private static int numberOfDevelopers = 10;
        private static IDeveloper[] developers;

        private static void Print ()
        {
            for (int i = 0; i < numberOfDevelopers; i++)
            {
                Console.WriteLine(developers[i].ToString());
            }
        }

        private static string RandomString()
        {
            Random rand = new Random();
            int stringLength = rand.Next(4, 10);
            var builder = new StringBuilder(stringLength);
            char offsetLower = 'a';
            char offsetUpper = 'A';

            const int lettersOffset = 26;
            builder.Clear();
            for (var j = 0; j < stringLength; j++)
            {
                char @char;
                if (j == 0)
                {
                    @char = (char)rand.Next(offsetUpper, offsetUpper + lettersOffset);
                }
                else
                {
                    @char = (char)rand.Next(offsetLower, offsetLower + lettersOffset);
                }
                builder.Append(@char);
            }
            return builder.ToString();
        }

        static void Main(string[] args)
        {

            //Create array of IDeveloper and add some Programmers and Builders to it

            //Console.WriteLine("Please enter number of developers that should be created.\nNumber of developers = ");
            //int numberOfDevelopers = Int32.Parse (Console.ReadLine());
            developers = new IDeveloper[numberOfDevelopers];
            Random rand = new Random();

            for (int i = 0; i < numberOfDevelopers; i++)
            {
                developers[i] = new Builder();
            }
            for (int i = 0; i < numberOfDevelopers - 2; i++)
            {
                developers[rand.Next(0, numberOfDevelopers)] = new Programmer();
            }

            //Print all elements in array
            Console.WriteLine("\n\n\nAll elements in array:\n");
            Print();

            //Call Create() and Destroy() methods, property Tool for all elements of array
            Console.WriteLine("\nSet property Tool, Call Create() and Destroy() methods for all elements in array:\n");
            for (int i = 0; i < numberOfDevelopers; i++)
            {
                developers[i].Tool = RandomString();
                developers[i].Create();
                developers[i].Destroy();
            }

            //Sort elements in Array by order of their creation
            Array.Sort(developers);

            //Print all elements in array
            Console.WriteLine("\nSorted elements in array:\n");
            Print();
        }
    }
}
