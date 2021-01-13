using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_core_ppt8_task
{
    class Program
    {
        private static void PrintAllPeople(List<Person> people)
        {
            foreach (Person person in people)
            {
                person.Print();
            }
        }

        static void Main(string[] args)
        {
            //specify a list of Person type and add objects of each type to it
            List<Person> people = new List<Person>();
            people.Add(new Person("person"));
            people.Add(new Person("person2"));
            people.Add(new Student("student"));
            people.Add(new Staff("staff", 1234));
            people.Add(new Teacher("teacher", "subject1", 234));
            people.Add(new Teacher("teacher", "subject2", 34));
            people.Add(new Developer("developer", "senior", 12345));

            //Call for each item in the list method Print ()
            PrintAllPeople(people);

            //Enter the person's name. If this name present in  list - print information about this person
            Console.Write("\nPlease enter person's name you want to check:\nName = teacher\n");
            //string findName = Console.ReadLine();
            string findName = "teacher";
            foreach (Person person in people)
            {
                if (person.Name == findName)
                {
                    person.Print();
                }
            }

            //Sort list by name, output to file
            people.Sort();
            Console.WriteLine("\nSorted List:");
            PrintAllPeople(people);

            Person staff = new Staff("asd", 1234);

            //Create a list of Employees and move only workers there.
            IEnumerable<Person> employees =
                from person in people
                where ((person.GetType() == typeof(Staff)) || (person.GetType() == typeof(Teacher))
                || (person.GetType() == typeof(Developer)))
                orderby person.Salary
                select person;


            //Person staff = new Staff("asd", 1234);
            //foreach (Person person in people)
            //{
            //    if (person.GetType().IsInstanceOfType(staff) || (person.GetType().ToString() == "Teacher")
            //        || (person.GetType().ToString() == "Developer"))
            //    {
            //        employees.Add(person);
            //    }
            //}

            ////Sort them by salary.
            //employees.Sort();

            //Print all employees sorted by salary
            Console.WriteLine("\nAll employees sorted by salary: ");
            foreach (Person employee in employees)
            {
                employee.Print();
            }
        }
    }
}
