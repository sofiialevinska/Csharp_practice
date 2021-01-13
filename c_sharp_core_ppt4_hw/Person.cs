using System;
namespace c_sharp_core_ppt4_hw
{
    public class Person
    {
        public string name;
        private DateTime birthYear;
        private static int counter;
        private int personsNumber;

        //properties for access to above fields (only get)
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public DateTime BirthYear
        {
            get
            {
                return this.birthYear;
            }
        }

        //default constructor
        public Person()
        {
            counter++;
            personsNumber = counter;
        }

        //constructor with 2 parameters 
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = new DateTime(birthYear, DateTime.Now.Month, DateTime.Now.Day);
            counter++;
            personsNumber = counter;
        }

        //method Age() - to calculate the age of person
        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        //method Input() - to input information about person
        public void Input()
        {
            Console.Write("\nPlease enter person's name.\nPerson's name = ");
            this.name = Console.ReadLine();
            Console.Write("Please enter person's birthday year.\nPerson's birthday year = ");
            this.birthYear = DateTime.Parse(Console.ReadLine());
        }

        //method ChangeName() - to change the name of person
        public void ChangeName(string name)
        {
            this.name = name;
        }

        //Overload the method ToString()
        public override string ToString()
        {
            return (" name is " + Name + ", birthday year = " + BirthYear.Year + ", age = " + Age() + ";");
        }

        //method Output() - to output information about person(call ToString())
        public void Output()
        {
            Console.WriteLine("Person" + personsNumber + ToString());
        }

        //Overload the operator== (equal by name)
        public static bool operator ==(Person person1, Person person2)
        {
            return (person1.name == person2.name);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return (person1.name != person2.name);
        }
    }
}
