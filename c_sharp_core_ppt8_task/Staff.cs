using System;
namespace c_sharp_core_ppt8_task
{
    public class Staff: Person
    {
        public Staff(string name, int salary): base (name)
        {
            Salary = salary;
        }
    }
}
