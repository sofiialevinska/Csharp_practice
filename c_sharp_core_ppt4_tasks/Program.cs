using System;

namespace c_sharp_core_ppt4_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter data about 3 cars - variant1
            Car car1 = new Car("car1", "white", 98);
            Car car2 = new Car("car2", "green", 200);
            Car car3 = new Car("car1", "blue", 98);

            ////Enter data about 3 cars - variant2
            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();

            //car1.Input();
            //car2.Input();
            //car3.Input();

            //Decrease cars prices by 10%, display info about the car.
            double percentageToChangePrice = -10;
            car1.ChangePrice(percentageToChangePrice);
            car2.ChangePrice(percentageToChangePrice);
            car3.ChangePrice(percentageToChangePrice);

            car1.Print();
            car2.Print();
            car3.Print();

            //Enter a new color and paint the car with the color white in the specified color
            string newColor = "black";

            Car[] cars = new Car[3] { car1, car2, car3 };
            foreach (Car car in cars)
            {
                if (car.Color == "white")
                {
                    car.Color = newColor;
                    car.Print();
                }
            }

            //print cars that are equal
            for (int i = 0; i < cars.Length - 1; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        Console.WriteLine("\ncar{0} == car{1}", i + 1, j + 1);
                    }
                }
            }

            //print info about car1 using method ToString()
            Console.WriteLine("\ncar1.ToString() = {0}", car1.ToString());
        }
    }
}