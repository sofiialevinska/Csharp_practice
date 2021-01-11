using System;
namespace c_sharp_core_ppt5_hw
{
    public class Programmer: IDeveloper, IComparable
    {
        private string language;
        private string tool;
        private static int programmerCounter;
        private int programmerNumber;

        public string Tool {get; set;}

        public int Counter { get; set; }

        public Programmer()
        {
            programmerCounter++;
            programmerNumber = programmerCounter;
            Counter = programmerCounter;
        }
        public void Create()
        {
            Console.WriteLine("Programmer{0} is created.", programmerNumber);
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer{0} is destroyed.", programmerNumber);
        }

        public override string ToString()
        {
            return "Programmer" + programmerNumber + "; ";
        }

        public int CompareTo(object obj)
        {
            IDeveloper p = obj as IDeveloper;
            if (p != null)
                return this.Counter.CompareTo(p.Counter);
            else
                throw new ArgumentException("Object is not Programmer");
        }
    }
}
