using System;
using System.Collections.Generic;

namespace c_sharp_core_ppt5_task5_2
{
    class Program
    {
        private static List<int> myColl;

        //print all elements in collection
        public static void Print()
        {
            foreach (int elem in myColl)
            {
                Console.Write(elem + " ");
            }
        }

        private static bool Greater20 (int obj)
        {
            return obj > 20;
        }

        private static bool EqualsMinus10(int obj)
        {
            return obj == -10;
        }

        static void Main(string[] args)
        {
            myColl = new List<int>();

            //add 9 random integers to myColl
            Random rand = new Random();
            int numberOfElements = 10;
            for (int i=0; i<numberOfElements-2; i++)
            {
                myColl.Add(rand.Next(-50, 50));
            }

            //insert '-10' integer to myCall with random index
            myColl.Insert(rand.Next(0, 9), -10);
            myColl.Insert(rand.Next(0, 9), -10);

            //print all elements from collection
            Console.WriteLine("Collection with 10 random integer elements: ");
            Print();
            Console.WriteLine();

            //find and print all positions of element '-10' in the collection
            Console.Write("\nPositions of element -10 in the collection: ");
            for (int i = 0; i<myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            //remove from collection elements, which are greater then 20.
            Predicate<int> predicate = Greater20;
            myColl.RemoveAll(predicate);

            //print all elements from collection
            Console.WriteLine("\nCollection without elements, which are greater then 20: ");
            Print();
            Console.WriteLine();

            //insert elements 1,-3,-4 in positions 2, 8, 5
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);

            //print all elements from collection
            Console.WriteLine("\nCollection where elements 1,-3,-4 were inserted in positions 2, 8, 5: ");
            Print();
            Console.WriteLine();

            //sort collection 
            myColl.Sort ();

            //print all elements from collection
            Console.WriteLine("\nSorted collection: ");
            Print();
        }
    }
}
