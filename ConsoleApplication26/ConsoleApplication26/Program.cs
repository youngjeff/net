using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入所要读取的文件的名称:");
            string readName = Console.ReadLine();

            Console.WriteLine("\n 输入所要写入的文件的名称: ");
            string writeName = Console.ReadLine();

            Stream StreamRead = File.OpenRead(readName);
            Stream StreamWrite = File.OpenWrite(writeName);
            byte[] b = new byte[512];
            int intRead = 0;

            intRead = StreamRead.Read(b, 0, b.Length);
            Console.WriteLine("\n 总共读取" + intRead + " 个字节!!");
            StreamWrite.Write(b, 0, intRead);

            StreamRead.Close();
            StreamWrite.Close();

            Console.WriteLine("文件复制完毕,请按【enter】 离开!!");
        }
    }
}
