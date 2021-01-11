using System;
namespace c_sharp_core_ppt5_hw
{
    public class Builder: IDeveloper, IComparable
    {
        private string tool;
        public string Tool
        {
            get => tool;
            set => tool = value;
        }
        private static int builderCounter;
        private int builderNumber;
        public int Counter { get; set; }

        public Builder()
        {
            builderCounter++;
            builderNumber = builderCounter;
            Counter = builderCounter;
        }
        public void Create ()
        {
            Console.WriteLine("Builder{0} is created. Tool is {1}.", builderNumber, tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Builder{0} is destroyed.", builderNumber);
        }

        public override string ToString()
        {
            return "Builder" + builderNumber + "; ";
        }

        public int CompareTo(object obj)
        {
            IDeveloper b = obj as IDeveloper;
            if (b != null)
                return this.Counter.CompareTo(b.Counter);
            else
                throw new ArgumentException("Object is not Builder");
        }
    }
}
