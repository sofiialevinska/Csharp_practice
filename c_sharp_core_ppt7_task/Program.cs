using System;
using System.IO;

namespace c_sharp_core_ppt7_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_task/txt/data.txt";
            string writePath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_task/txt/rez.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }

                File.WriteAllText(writePath, text);

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("\nMore text More text More text");
                    sw.WriteLine(" 1234 " + 1234 + " 1234 ");
                }

                string addText = "WriteAllText WriteAllText WriteAllText" + 5678 + " Five Six Seven Eight";
                File.AppendAllText(writePath, addText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
