using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream__Feb8
{
    //    internal class Program
    //    {
    //        class FileRead
    //        {
    //            public void ReadData()
    //            {
    //                FileStream fs = new FileStream("c:\\txt.txt", FileMode.Open, FileAccess.Read);
    //                StreamReader sr = new StreamReader(fs);
    //                Console.WriteLine(" you want to Read to the file");
    //                sr.BaseStream.Seek(0,SeekOrigin.Begin);
    //                string str=sr.ReadLine();
    //                while(str!= null)
    //                {
    //                    Console.WriteLine(str);
    //                    str = sr.ReadLine();
    //                }
    //                Console.ReadLine();
    //                sr.Close();
    //                fs.Close();

    //                //string str=Console.ReadLine();
    //                //sw.WriteLine(str);
    //                //sw.Flush();
    //                //sw.Close();
    //                //fs.Close();

    //            }
    //        }
    //        static void Main(string[] args)
    //        {
    //            FileRead read= new FileRead();
    //            read.ReadData();
    //        }
    //    }


    //}


    //public class FileStreamExample
    //{
    //    public static void Main(string[] args)
    //    {
    //        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);//creating file stream  
    //        f.WriteByte(65);//writing byte into stream  
    //        f.Close();//closing stream  
    //    }
    //}


    //public class FileStreamExample
    //{
    //    public static void Main(string[] args)
    //    {
    //        FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
    //        for (int i = 65; i <= 90; i++)
    //        {
    //            f.WriteByte((byte)i);
    //        }
    //        f.Close();
    //    }
    //}

    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("Desktop:\\mike.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
        }
    }
}
