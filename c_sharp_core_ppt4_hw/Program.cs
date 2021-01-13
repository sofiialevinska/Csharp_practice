using System;
using System.Text;

namespace c_sharp_core_ppt4_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6];

            ////Create 6 objects of Person type and input information about them
            ////variant1 - input data from Console
            //for (int i=0; i<persons.Length; i++)
            //{
            //    persons[i]= new Person();
            //    persons[i].Input();
            //}

            //Create 6 objects of Person type and input information about them
            //variant2 - input data for 3 objects automatically using class Random
            Random rand = new Random();
            int nameSize = 7;
            var builder = new StringBuilder(nameSize);
            char offsetLower = 'a';
            char offsetUpper = 'A';
            const int lettersOffset = 26;
            for (int i = 0; i < persons.Length - 3; i++)
            {
                builder.Clear();
                for (var j = 0; j < nameSize; j++)
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
                string randName = builder.ToString();
                int randYear = rand.Next(1900, DateTime.Now.Year);
                persons[i] = new Person(randName, randYear);
            }

            //variant 2 - input data for 3 Objects manually
            persons[3] = new Person("Ivan", 1990);
            persons[4] = new Person("Ivan", 2000);
            persons[5] = new Person("Ivan", 2020);

            //Calculate and write to console the name and Age of each person;
            Console.WriteLine("\n\nWriting to console the name and Age of each person:\n");
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            //Change the name of persons, which Age is less then 16, to "Very Young".
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age() <= 16)
                {
                    persons[i].name = "Very Young";
                }
            }

            //Output information about all persons.
            Console.WriteLine("\nOutput information about all persons:\n");
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            //Find and output information about Persons with the same names(use ==)
            Console.WriteLine("\nPersons with the same names:\n");
            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine("Person{0} == Person{1}", i + 1, j + 1);
                        persons[i].Output();
                        persons[j].Output();
                    }
                }
            }
        }
    }
}
