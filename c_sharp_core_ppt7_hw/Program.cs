using System;
using System.Collections.Generic;
using System.IO;

namespace c_sharp_core_ppt7_hw
{
    class Program
    {
        private static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        private static string readPath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_hw/phoneBook.txt";
        private static string writePath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_hw/numbers.txt";
        public static void ppt7_hw1()
        {
            phoneBook = new Dictionary<string, string>();
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        phoneBook.Add(line.Split(" ")[0], line.Split(" ")[1]);
                    }
                }

                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("All telephone numbers: \n");
                    foreach (var pairs in phoneBook)
                    {
                        sw.WriteLine(pairs.Value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ppt7_hw2()
        {
            ppt7_hw1();
            Console.WriteLine("Please enter name of existing in the PhoneBook person:\nName = ");
            string name = Console.ReadLine();
            foreach (var pairs in phoneBook)
            {
                if (pairs.Key == name)
                {
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine($"\n\nName '{name}' is founded in PhoneBook. \nTelephone number of '{name}' " +
                            $"is {pairs.Value}");
                    }
                }
            }
        }

        public static void ppt7_hw3()
        {
            ppt7_hw1();
            string newWritePath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_hw/new.txt";

            Dictionary<string, string> phonesFormatedPhoneBook = new Dictionary<string, string>();
            foreach (var pairs in phoneBook)
            {
                if (pairs.Value.Substring(0, 2) == "80")
                {
                    string newValue = pairs.Value.Insert(0, "+3");
                    phonesFormatedPhoneBook.Add(pairs.Key, newValue);
                }
                else
                {
                    phonesFormatedPhoneBook.Add(pairs.Key, pairs.Value);
                }
            }
            using (StreamWriter sw = new StreamWriter(newWritePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Changed telephone numbers to '+380' formats:\n");
                foreach (var pairs in phonesFormatedPhoneBook)
                {
                    sw.WriteLine(pairs.Value);
                }
            }

        }

        static void Main(string[] args)
        {
            //ppt7_hw1();
            //ppt7_hw2();
            ppt7_hw3();
        }
    }
}
