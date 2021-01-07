using System;
namespace c_sharp_core_ppt4_tasks
{
    //Define class Car with fields name, color, price and const field CompanyName          
    public class Car
    {
        private string name;
        private double price;
        private const string CompanyName = "Sofiia Levinska";

        //Constructor default                                       
        public Car()
        {
        }

        //Constructor with parameters
        public Car(string name, string color, double price)
        {
            this.name = name;
            Color = color;
            this.price = price;
        }

        //property to access the color field
        public string Color { get; set; }

        //method Input () - to enter car data from the console
        public void Input()
        {
            Console.Write("\nPlease enter car's name.\nCar's name = ");
            this.name = Console.ReadLine();
            Console.Write("Please enter car's color.\nCar's color = ");
            Color = Console.ReadLine();
            Console.Write("Please enter car's price.\nCar's price = ");
            this.price = Int32.Parse(Console.ReadLine());
        }

        //method Print () - to output the machine data to the console
        public void Print()
        {
            Console.Write("\nCar's name = {0};", this.name);
            Console.Write(" Car's color = {0};", Color);
            Console.WriteLine(" Car's price = {0:f1}", this.price);
        }

        //method ChangePrice (double x) - to change the price by x%
        public void ChangePrice(double x)
        {
            if (x > 0)
            {
                price = price * (1 + x / 100);
            }
            else
            {
                price = price * (1 - Math.Abs(x) / 100);
            }
        }

        //Overload the operator == for the class Car (cars - equal if the name and price are equal)
        public static bool operator ==(Car car1, Car car2)
        {
            return ((car1.name == car2.name) && (car1.price == car2.price));
        }

        public static bool operator !=(Car car1, Car car2)
        {
            return ((car1.name != car2.name) && (car1.price != car2.price));
        }

        //Overload the method ToString() in the class Car, which returns a line with data about the car
        public override string ToString()
        {
            return ("(" + name + "; " + Color.ToString() + "; " + price + ")");
        }
    }
}