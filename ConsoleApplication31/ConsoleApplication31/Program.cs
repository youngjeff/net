using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入所要读取的文件名称 : ");
            string readFileName = Console.ReadLine();
            Console.WriteLine("输入开始读取的文件位置 : ");
            int Position = int.Parse(Console.ReadLine());
            Console.WriteLine("输入所要复制的文件名称 ： ");           
            string writeFileName = Console.ReadLine();

            FileStream fileReadStream = new FileStream(readFileName, FileMode.Open, FileAccess.Read);
            fileReadStream.Position = Position;
            FileStream fileWriteStream = new FileStream(writeFileName, FileMode.Create, FileAccess.Write);
            byte[] b = new byte[512];
            int intRead = 0;
            intRead = fileReadStream.Read(b, 0, b.Length);
            Console.WriteLine("总共读取" + intRead + "个字节");
            fileWriteStream.Write(b, 0, intRead);

            fileReadStream.Close();
            fileWriteStream.Close();
        }
    }
}
