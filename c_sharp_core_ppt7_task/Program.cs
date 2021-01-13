using System;
using System.IO;

namespace c_sharp_core_ppt7_task
{
    class Program
    {
        protected static float CalculateFolderSize(string folder)
        {
            float folderSize = 0.0f;
            try
            {
                //Checks if the path is valid or not
                if (!Directory.Exists(folder))
                    return folderSize;
                else
                {
                    try
                    {
                        foreach (string file in Directory.GetFiles(folder))
                        {
                            if (File.Exists(file))
                            {
                                FileInfo finfo = new FileInfo(file);
                                folderSize += finfo.Length;
                            }
                        }

                        foreach (string dir in Directory.GetDirectories(folder))
                            folderSize += CalculateFolderSize(dir);
                    }
                    catch (NotSupportedException e)
                    {
                        Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unable to calculate folder size: {0}", e.Message);
            }
            return folderSize;
        }

        static void Main(string[] args)
        {
            //string readPath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_task/txt/data.txt";
            //string writePath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_task/txt/rez.txt";
            //string text = "";
            //try
            //{
            //    using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
            //    {
            //        text = sr.ReadToEnd();
            //    }

            //    File.WriteAllText(writePath, text);

            //    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            //    {
            //        sw.WriteLine("\nMore text More text More text");
            //        sw.WriteLine(" 1234 " + 1234 + " 1234 ");
            //    }

            //    string addText = "WriteAllText WriteAllText WriteAllText" + 5678 + " Five Six Seven Eight";
            //    File.AppendAllText(writePath, addText);
            //}
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            string folderName = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core";
            string writePath = @"/Users/sofiiageletukha/Desktop/Coding/SETtest/hw/hw5/c_sharp_core/c_sharp_core_ppt7_task/txt/DirectoryC.txt";
            try
            {
                if (Directory.Exists(folderName))
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("\nSub folders of folder c_sharp_core:");
                        string[] subFolders = Directory.GetDirectories(folderName);
                        foreach (string subFolder in subFolders)
                        {
                            sw.WriteLine("\n"+subFolder);
                            DirectoryInfo subFolderInfo = new DirectoryInfo(subFolder);
                            sw.WriteLine($"Folder's Name: {subFolderInfo.Name}");
                            sw.WriteLine($"Folder's Creation Time: {subFolderInfo.CreationTime}");
                            sw.WriteLine($"Folder's Size: {CalculateFolderSize(subFolder)}  bytes");
                        }

                        sw.WriteLine("\n\nFiles of folder c_sharp_core:");
                        string[] files = Directory.GetFiles(folderName);
                        foreach (string file in files)
                        {
                            sw.WriteLine("\n" + file);
                            FileInfo fileInfo = new FileInfo(file);
                            sw.WriteLine($"File's Name: {fileInfo.Name}");
                            sw.WriteLine($"File's Creation Time: {fileInfo.CreationTime}");
                            sw.WriteLine($"File's Type: {fileInfo.Extension}");
                            sw.WriteLine($"File's Size: {fileInfo.Length} bytes");
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
