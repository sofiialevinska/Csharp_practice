using System;
namespace c_sharp_core_ppt8_task
{
    public class Person: IComparable
    {
        private string name;
        private int salary;
        public string Name { get { return name; } }
        public int Salary { get; protected set; }

        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Print ()
        {
            Console.WriteLine("Name: {0}", this.name);
        }

        public virtual int CompareTo(object obj)
        {
            Person p = obj as Person;
            if (p != null)
                return Name.CompareTo(p.Name);
            else
                throw new ArgumentException("Object is not Person");
        }
    }
}
