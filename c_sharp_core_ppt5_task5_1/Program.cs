using System;
using System.Collections.Generic;

namespace c_sharp_core_ppt5_task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create List of IFlyable objects and add some Birds and Planes to it.
            List<IFlyable> flyingObjects = new List<IFlyable>();
            flyingObjects.Add(new Bird());
            flyingObjects.Add(new Bird());
            flyingObjects.Add(new Bird());
            flyingObjects.Add(new Bird());
            flyingObjects.Add(new Plane());
            flyingObjects.Add(new Plane());
            flyingObjects.Add(new Plane());

            //Call Fly() method for every item from the list of it
            foreach (IFlyable flyable in flyingObjects)
            {
                flyable.Fly();
            }
        }
    }
}
