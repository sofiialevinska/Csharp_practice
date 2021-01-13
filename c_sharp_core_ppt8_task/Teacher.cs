using System;
namespace c_sharp_core_ppt8_task
{
    public class Teacher : Staff
    {
        protected string subject;
        public Teacher(string name, string subject, int salary) : base(name, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine("Name: {0}; Subject: {1}", Name, this.subject);
        }
    }
}
