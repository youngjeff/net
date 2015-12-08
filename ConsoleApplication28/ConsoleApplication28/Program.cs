using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入所要读取的文件名称:");
            //string readFileName = Console.ReadLine();
            string readFileName = "text.txt";
            Console.WriteLine("输入要复制的文件名称");
            //string WriteFileName = Console.ReadLine();
            string WriteFileName = "./text1.txt";
            FileStream FileReadStream = new FileStream(readFileName, FileMode.Open, FileAccess.Read);
            FileStream FileWriteStream = new FileStream(WriteFileName, FileMode.Create, FileAccess.Write);
            byte[] b = new byte[512];
            int intRead = 0;
            intRead = FileReadStream.Read(b, 0, b.Length);
            Console.WriteLine("总共读取" + intRead + "个字节!!");
            FileWriteStream.Write(b, 0, intRead);
            FileReadStream.Close();
            FileWriteStream.Close();

            Console.WriteLine("文件复制完毕，请按[Enter]离开!!");
            Console.ReadLine();
        }
    }
}
