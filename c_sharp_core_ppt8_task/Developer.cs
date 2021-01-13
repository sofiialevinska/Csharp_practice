using System;
namespace c_sharp_core_ppt8_task
{
    public class Developer : Staff
    {
        private string level;
        public Developer(string name, string level, int salary) : base(name, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.WriteLine("Name: {0}; Level: {1}", Name, this.level);
        }
    }
}
