using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{
    public class FileIO
    {
        public static void FileExists()
        {
            String path = @"D:\BridgelabFileIo\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"D:\BridgelabFileIo\Example.txt";
            String[] lines;
            //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = @"D:\BridgelabFileIo\Example.txt";
            String lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            String path = @"D:\BridgelabFileIo\Example.txt";
            String copypath = @"D:\BridgelabFileIo\Example1.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            String path = @"D:\BridgelabFileIo\Example1.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = @"D:\BridgelabFileIo\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {

                //string data = sr.ReadToEnd();
                //Console.WriteLine(data);

                String s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

                //if (sr.Peek() > 0)
                //{
                //    Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}

                //foreach (var line in sr.ReadLine())
                //{
                //    Console.WriteLine(line);
                //}

            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"D:\BridgelabFileIo\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome1");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }



    }
}
