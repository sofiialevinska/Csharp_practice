using System;

namespace c_sharp_core_ppt6_task_hw
{
    class Program
    {
        private static void Div (int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b can not be zero");
            }
            else
            {
                double result = Convert.ToDouble(a) / Convert.ToDouble(b);
                Console.WriteLine("a/b = {0:f2}", result);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            Console.Write("\nPlease enter any integer number.\nNumber = ");
            int number = Int32.Parse(Console.ReadLine());
            if ((number >= start) && (number <= end))
            {
                Console.WriteLine($"Number {number} is im the range [{start}..{end}]");
            }
            else
            {
                throw new Exception($"Number {number} is NOT im the range [{start}..{end}]");
            }
        }

        static void Main(string[] args)
        {
            bool repeat = true;

            ////Create method Div(), which calculates the dividing of two int numbers.
            ////In Main read two int numbers and call this method.
            ////Catch appropriative exceptions.
            ////Throwing exception if dividing of two double numbers.
            //int b = 0;
            //do
            //{
            //    try
            //    {
            //        Console.Write("\nPlease enter two integers for deviding a to b:\na = ");
            //        int a = Int32.Parse(Console.ReadLine());
            //        Console.Write("b = ");
            //        b = Int32.Parse(Console.ReadLine());
            //        Div(a, b);
            //    }
            //    catch (Exception ex) when (b == 0)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //    catch (FormatException fe)
            //    {
            //        Console.WriteLine($"Error: Please enter two integers. " + fe.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("If you want to try more press 'Y'");
            //        string symbol = Console.ReadLine();
            //        if (symbol == "Y")
            //        {
            //            repeat = true;
            //        }
            //        else
            //        {
            //            repeat = false;
            //        }
            //    }
            //} while (repeat == true);

            //Write a method ReadNumber(int start, int end),
            //which reads from Console  integer numbers and returns it,
            //if it is in the range [start...end].
            //If an invalid number or non-number text is read,
            //the method should throw an exception.
            //Using this method write a method Main(),
            //that has to enter 10 numbers:
            //a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

            do
            {
                try
                {
                    Console.Write("\nPlease enter start and end ranges as integers:\nstart = ");
                    int start = Int32.Parse(Console.ReadLine());
                    Console.Write("end = ");
                    int end = Int32.Parse(Console.ReadLine());
                    int repeatMethod = 10;
                    for (int i=0; i<repeatMethod; i++)
                    {
                        ReadNumber(start, end);
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($"Error: Please enter two integers. " + fe.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("If you want to try more press 'Y'");
                    string symbol = Console.ReadLine();
                    if (symbol == "Y")
                    {
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }
                }

            } while (repeat == true);
        }
    }
}
