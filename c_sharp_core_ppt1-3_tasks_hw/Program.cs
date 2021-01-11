using System;

namespace c_sharp_core_ppt1_3_tasks_hw
{
    class Program
    {
            private static void ppt1Task1()
            {
                Console.WriteLine("Please enter numbers");
                Console.Write("a = ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = Int32.Parse(Console.ReadLine());
                Console.Write("a+b = {0} \na-b = {1} \na*b = {2} \na/b = {3:F2}", a + b, a - b, a * b, Convert.ToDouble(a) / Convert.ToDouble(b));
            }

            private static void ppt1Task2()
            {
                Console.WriteLine("How are you?");
                string str = Console.ReadLine();
                Console.WriteLine("You are {0}", str);
            }

            private static void ppt1Task3()
            {
                Console.WriteLine("Please enter three variables of char type");
                Console.Write("char1 = ");
                char char1 = char.Parse(Console.ReadLine());
                Console.Write("char2 = ");
                char char2 = char.Parse(Console.ReadLine());
                Console.Write("char3 = ");
                char char3 = char.Parse(Console.ReadLine());

                Console.WriteLine("You enter {0}, {1}, {2}", char1, char2, char3);
            }

            private static void ppt1Task4()
            {
                Console.WriteLine("Please enter two integer numbers");
                Console.Write("integer1 = ");
                int integer1 = Int32.Parse(Console.ReadLine());
                Console.Write("integer2 = ");
                int integer2 = Int32.Parse(Console.ReadLine());

                if ((integer1 > 0) && (integer2 > 0))
                {
                    Console.WriteLine("Both numbers are positive");
                }
                else
                {
                    Console.WriteLine("Both numbers are NOT positive");
                }

            }

            private static void ppt1HWTask1a()
            {
                Console.WriteLine("Please enter length of square as integer number");
                Console.Write("a = ");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Area of square is {0}.\nPerimetr of square is {1}.", a * a, 4 * a);
            }

            private static void ppt1HWTask1b()
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("How old are you, {0}?", name);
                string age = Console.ReadLine();
                Console.WriteLine("Your name is {0} and you are {1} years old.", name, age);
            }

            private static void ppt1HWTask1c()
            {
                Console.WriteLine("Please enter radius of circle as floating point number");
                Console.Write("r = ");
                double r = Double.Parse(Console.ReadLine());
                double pi = 3.14;
                Console.WriteLine("Length of the circle is {0}.\nArea of the circle is {1}.\nVolume of the circle is {2}.", 2 * pi * r, pi * r * r, 4 / 3 * pi * r * r * r);
            }

            private static void ppt2Task1()
            {
                Console.WriteLine("Please enter two integer numbers");
                Console.Write("- to check if number can represent the day\ninteger1 = ");
                int integer1 = Int32.Parse(Console.ReadLine());
                Console.Write("- to check if number can represent the month\ninteger2 = ");
                int integer2 = Int32.Parse(Console.ReadLine());

                string answer = (integer1 >= 1 && integer1 <= 31) ? "1 is a day" : "1 is not a day";
                Console.WriteLine("integer{0}", answer);

                answer = (integer1 >= 1 && integer1 <= 12) ? "2 is a month" : "2 is not a month";
                Console.WriteLine("integer{0}", answer);
            }
            private static void ppt2Task2()
            {
                Console.WriteLine("Please enter floating point number");
                Console.Write("number = ");
                string number = Console.ReadLine();
                char[] separators = new char[] { '.', ',' };
                string[] result = number.Split(separators);
                char[] numbersAfterPointArr = result[1].ToCharArray();
                int sum = (int)char.GetNumericValue(numbersAfterPointArr[0]) + (int)char.GetNumericValue(numbersAfterPointArr[1]);
                Console.WriteLine("Sum of the first 2 digits after the point of number {0} is {1}.", number, sum);
            }

            private static void ppt2Task3()
            {
                Console.WriteLine("Please enter integer number that represents the time of day (hour).");
                Console.Write("hour = ");
                int hour = Int32.Parse(Console.ReadLine());
                switch (hour)
                {
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        {
                            Console.WriteLine("Good morning!");
                            break;
                        }
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                        {
                            Console.WriteLine("Good afternoon!");
                            break;
                        }
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                    case 21:
                        {
                            Console.WriteLine("Good evening!");
                            break;
                        }
                    case 22:
                    case 23:
                    case 24:
                    case 0:
                    case 1:
                    case 2:
                        {
                            Console.WriteLine("Good night!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Number is not an hour in form of integer");
                            break;
                        }
                }
            }


        private enum TestCaseStatus
        {
            Pass, Fail, Blocked, WP, Unexecuted
        }

        private static void ppt2Task4()
        {
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
        }

        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;

            public override string ToString()
            {
                return string.Format("({0},{1},{2})", red, green, blue);

            }
        }

        private static void ppt2Task5()
        {
            RGB white;
            RGB black;

            white.red = 255;
            white.green = 255;
            white.blue = 255;

            black.red = 0;
            black.green = 0;
            black.blue = 0;

            Console.WriteLine("RGB of white color is {0}", white);
            Console.WriteLine("RGB of black color is {0}", black);
        }

        private static void ppt2HWTask1a()
        {
            Console.WriteLine("Please enter three floating point numbers");
            Console.Write("floatNumber1 = ");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("floatNumber2 = ");
            float number2 = float.Parse(Console.ReadLine());
            Console.Write("floatNumber3 = ");
            float number3 = float.Parse(Console.ReadLine());
            if ((number1 >= -5 && number1 <= 5) &&
                (number2 >= -5 && number2 <= 5) &&
                (number3 >= -5 && number3 <= 5))
            {
                Console.WriteLine("All numbers belong to the range [-5,5]");
            }
            else
            {
                Console.WriteLine("Not all numbers belong to the range [-5,5]");
            }
        }

        private static void ppt2HWTask1b()
        {
            Console.WriteLine("Please enter three integer numbers");
            Console.Write("integerNumber1 = ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("integerNumber2 = ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.Write("integerNumber3 = ");
            int number3 = Int32.Parse(Console.ReadLine());

            int max = number1 > number2 ?
                number1 > number3 ? number1 : number2 > number3 ? number2 : number3 :
                number2 > number3 ?
                number2 : number3;
            int min = number1 < number2 ?
                number1 < number3 ?
                number1 : number2 < number3 ?
                number2 : number3 : number2 < number3 ?
                number2 : number3;

            Console.WriteLine("The largest integer number is {0}", max);
            Console.WriteLine("The lowest integer number is {0}", min);

        }

        private enum HTTPError
        {
            Informational, Success, Redirection, ClientError, ServerError
        }

        private static void ppt2HWTask1c()
        {
            Console.WriteLine("Please enter number of HTTP Error ");
            Console.Write("httpNumber = ");
            string httpNumber = Console.ReadLine();
            int firstNumber = Int32.Parse(httpNumber.Substring(1, 1));
            switch (firstNumber)
            {
                case 1:
                    Console.WriteLine(HTTPError.Informational);
                    break;
                case 2:
                    Console.WriteLine(HTTPError.Success);
                    break;
                case 3:
                    Console.WriteLine(HTTPError.Redirection);
                    break;
                case 4:
                    Console.WriteLine(HTTPError.ClientError);
                    break;
                case 5:
                    Console.WriteLine(HTTPError.ServerError);
                    break;
                default:
                    Console.WriteLine("The code is not an HTPP Error");
                    break;
            }
        }

        private struct Dog
        {
            public string name;
            public string mark;
            public float age;

            public override string ToString()
            {
                return string.Format("Name: {0}; Mark: {1}; Age: {2}", name, mark, age);
            }

        }

        private static void ppt2HWTask1d()
        {
            Dog myDog;
            myDog.name = "Bonia";
            myDog.mark = "Taksa";
            myDog.age = 14;
            Console.WriteLine(myDog);
        }

        private static void ppt3Task1()
        {
            Console.WriteLine("Please enter two integer numbers");
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine("{0} integers in the range [{1}..{2}] are divided by 3 without remainder.", sum, a, b);
        }

        private static void ppt3Task2()
        {
            Console.WriteLine("Please enter any string");
            Console.Write("string = ");
            string s = Console.ReadLine();
            char[] charrArr = s.ToCharArray();
            for (int i = 0; i < charrArr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0} ", charrArr[i]);
                }
            }
        }

        private static void ppt3Task3()
        {
            Console.WriteLine("Please enter the name of the drink (coffee, tea, juice, water).");
            Console.Write("drink = ");
            string drink = Console.ReadLine();
            double price = 0;
            switch (drink.ToLower())
            {
                case "coffee":
                    {
                        price = 10.22;
                        Console.WriteLine("Name of the drink is '{0}'.\nPrice of the drink {1} UAH", drink, price);
                        break;
                    }
                case "tea":
                    {
                        price = 10.22;
                        Console.WriteLine("Name of the drink is '{0}'.\nPrice of the drink {1} UAH", drink, price);
                        break;
                    }
                case "juice":
                    {
                        price = 10.22;
                        Console.WriteLine("Name of the drink is '{0}'.\nPrice of the drink {1} UAH", drink, price);
                        break;
                    }
                case "water":
                    {
                        price = 10.22;
                        Console.WriteLine("Name of the drink is '{0}'.\nPrice of the drink {1} UAH", drink, price);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There is no such drink in the system menu");
                        break;
                    }
            }


        }

        private static void ppt3Task4()
        {
            Console.WriteLine("Please enter the length of sequence");
            Console.Write("length = ");
            int length = Int32.Parse(Console.ReadLine());
            int sum = 0;
            int[] randomArr = new int[length];
            int min = -50;
            int max = 50;
            Random randNum = new Random();
            Console.WriteLine("The sequence of length {0} is:", length);
            for (int i = 0; i < length; i++)
            {
                randomArr[i] = randNum.Next(min, max);
                if (randomArr[i] > 0)
                {
                    sum += randomArr[i];
                }
                Console.Write("{0} ", randomArr[i]);
            }
            Console.WriteLine("\nSum of all positive elements in sequance is {0}", sum);
        }


        private static void ppt3Task5()
        {
            Console.WriteLine("Please enter the year as integer number");
            Console.Write("year = ");
            int year = Int32.Parse(Console.ReadLine());
            if (IsLeapYear(year))
            {
                Console.WriteLine("Year {0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("Year {0} is NOT a leap year", year);
            }
        }

        private static Boolean IsLeapYear(int year)
        {
            Boolean isLeapYear = false;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }
            return isLeapYear;
        }

        private static void ppt3Task6()
        {
            Console.WriteLine("Please enter integer number");
            Console.Write("intNumber = ");
            char[] intNumber = Console.ReadLine().ToCharArray();
            int sum = 0;
            foreach (char ch in intNumber)
            {
                sum += Int32.Parse(ch.ToString());
            }
            Console.WriteLine("Sum of digits of the entered integer number is {0}", sum);
        }

        private static void ppt3Task7()
        {
            Console.WriteLine("Please enter integer number");
            Console.Write("intNumber = ");
            string str = Console.ReadLine();
            char[] intNumber = str.ToCharArray();
            Boolean isOdd = true;
            foreach (char ch in intNumber)
            {
                if (Int32.Parse(ch.ToString()) % 2 != 0)
                {
                    isOdd = false;
                    break;
                }
            }
            if (isOdd)
            {
                Console.WriteLine("Entered integer number {0} contains only odd numbers", str);
            }
            else
            {
                Console.WriteLine("Entered integer number {0} DOES NOT contain only odd numbers", str);
            }
        }

        public static void Main(string[] args)
        {
            //ppt1Task1();
            //ppt1Task2();
            //ppt1Task3();
            //ppt1Task4();
            //ppt1HWTask1a();
            //ppt1HWTask1b();
            //ppt1HWTask1c();
            //ppt2Task1();
            //ppt2Task2();
            //ppt2Task3();
            //ppt2Task4();
            //ppt2Task5();
            //ppt2HWTask1a();
            //ppt2HWTask1b();
            //ppt2HWTask1c();
            //ppt2HWTask1d();
            //ppt3Task1();
            //ppt3Task2();
            //ppt3Task3();
            //ppt3Task4();
            //ppt3Task5();
            //ppt3Task6();
            ppt3Task7();
        }
    }
}
