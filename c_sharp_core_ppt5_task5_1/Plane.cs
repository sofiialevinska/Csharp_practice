using System;
namespace c_sharp_core_ppt5_task5_1
{
    public class Plane : IFlyable
    {
        public string Mark { get; private set; }
        public bool HighFly { get; private set; }
        public Plane()
        {
        }

        public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }

    }
}
