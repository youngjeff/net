using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream StreamRead = File.OpenRead("720p.h264");
            Stream StreamWrite = File.Create("test.txt");
            byte[] streamLength = new byte[4];
            int intRead = 0;
            intRead = StreamRead.Read(streamLength, 0, 4);
            //int number = Convert.ToInt32(streamLength);
            UnicodeEncoding converter = new UnicodeEncoding();
            string numberString = converter.GetString(streamLength);
            Console.Write(streamLength);
            Console.Read();
            
        }
    }
}
