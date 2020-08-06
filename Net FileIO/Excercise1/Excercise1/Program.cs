using System;
using System.IO;
using System.Collections;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"E:\,Accolite\Net FileIO";
            string file = @"E:\,Accolite\Net FileIO\file.txt";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (Directory.Exists(dir))
            {
                Console.WriteLine("Directory created");
            }
            //
            if (!File.Exists(file))
            {
                File.CreateText(file);
            }
            if (File.Exists(file))
            {
                Console.WriteLine("text file wiithin created directory created");
            }

            //
            Console.WriteLine("Writing into the files...");
                using (StreamWriter writer=new StreamWriter(file))
            {
                writer.WriteLine("Hello, you are in first line");
                writer.WriteLine("Second line of the file");
                writer.WriteLine("Third line");
                writer.WriteLine("Last line");

            }

            string reader = File.ReadAllText(file);
            Console.WriteLine(reader);

            Console.WriteLine("Counting number of words in file");
            StreamReader sr = new StreamReader(file);
            int counter = 0;
            string delim = " ,.";
            string[] fields = null;
            string line = null;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length; 
            }
            sr.Close();
            Console.WriteLine(counter);

            //
            Console.WriteLine("Writing into another file in reverse order line by line");
            string rfile = @"E:\,Accolite\Net FileIO\rfile.txt";
            if (!File.Exists(rfile))
            {
                File.CreateText(rfile);
            }
            StreamReader objReader = new StreamReader(file);
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();


            arrText.Reverse();
            
               
                using (StreamWriter writer = new StreamWriter(rfile))
                {
                foreach (string str in arrText)
                {
                    writer.WriteLine(str);
                    Console.WriteLine(str);

                }

                }
              



        }
    }
}
