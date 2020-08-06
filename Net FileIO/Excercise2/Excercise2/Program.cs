using System;
using System.IO;
using System.Text;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            string bfile = @"E:\,Accolite\Net FileIO\bfile.bin";
            try
            {
                
               // BinaryWriter bw = new BinaryWriter(new FileStream(bfile, FileMode.Create));
               // Encoding ascii = Encoding.ASCII;
                //BinaryWriter bwEncoder = new BinaryWriter(new FileStream(bfile, FileMode.Create), ascii);
                using (BinaryWriter bin = new BinaryWriter(File.Open(bfile, FileMode.Create)))
                {
                    //write into binary file
                    bin.Write("Mandeep Kumar Yadav");
                    bin.Write(100);
                    bin.Write("how u doing!");
                    bin.Write(true);
                    bin.Write(55.55);
                }
                Console.WriteLine("Data Written!");
            }
            catch(IOException io)
            {
                Console.WriteLine("Error is:{0}", io.Message);
            }
            //
            string ot = @"E:\,Accolite\Net FileIO\out.txt";

            using(FileStream fs = File.OpenRead(bfile))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);

                using (StreamWriter sw=new StreamWriter(ot))
                {
                    for(int i = 0; i < data.Length; i++)
                    {
                        if ((Convert.ToInt32(data[i]) >= 32) && (Convert.ToInt32(data[i]) <= 127) || (Convert.ToInt32(data[i]) == 10) || (Convert.ToInt32(data[i]) == 13))
                        {
                            sw.Write(Convert.ToChar(data[i]));
                        }
                    }
                    sw.Close();
                }
                fs.Close();
            }

            //
           


        }
    }
}
