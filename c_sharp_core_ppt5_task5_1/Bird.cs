using System;
namespace c_sharp_core_ppt5_task5_1
{
    public class Bird: IFlyable
    {
        public string Name { get; private set; }
        public bool CanFly { get; private set; } 
        public Bird()
        {
        }
        public void Fly ()
        {
            Console.WriteLine("The bird is flying");
        }
    }
}
