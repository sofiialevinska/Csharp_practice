using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_core_ppt5_hw2
{
    class Program
    {
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
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            int numberOfPersons = 7;
            Random rand = new Random();
            for (int i = 0; i < numberOfPersons; i++)
            {
                persons.Add(Convert.ToUInt32(i + rand.Next(1, 10000)), RandomString());
            }

            //Print all created persons
            Console.WriteLine("\nAll created persons:");
            foreach (KeyValuePair<uint, string> person in persons)
            {
                Console.WriteLine("ID = {0}, Name = {1};", person.Key, person.Value);
            }

            //Ask user to enter ID
            Console.Write("\nPlease enter user's ID. \nUser's ID = ");
            uint id = Convert.ToUInt32(Console.ReadLine());

            //Find and write corresponding Name from your Dictionary.
            //If you can't find this ID - say about it to user. 

            try
            {
                Console.WriteLine("Corresponding Name for ID '{0}' is '{1}'", id, persons[id]);
            }
            catch
            {
                Console.WriteLine("There is no person with id '{0}'. Please try again.", id);
            }
        }
    }
}
