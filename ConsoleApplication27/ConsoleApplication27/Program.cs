using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] b = new Byte[1024];
            byte[] mb = new Byte[1024];
            int intRead = 0;
            Console.WriteLine("输入所要读取的文件路径名称:");
            string readFileName = Console.ReadLine();
            Stream streamRead = File.OpenRead(readFileName);
            intRead = streamRead.Read(b, 0,1024);
            MemoryStream myMemoryStream = new MemoryStream(intRead);

            Console.WriteLine();
            Console.WriteLine("容量= " + myMemoryStream.Capacity.ToString());
            Console.WriteLine("数据长度=" + myMemoryStream.Length.ToString());

            myMemoryStream.Write(b, 0, intRead);

            Console.WriteLine("写入后容量= " + myMemoryStream.Capacity.ToString());
            Console.WriteLine("写入后数据长度= " + myMemoryStream.Length.ToString());
            Console.WriteLine("将内存数据流数据转成字节");

            mb = myMemoryStream.ToArray();
            for(int i=0;i<intRead;i++)
            {
                Console.Write(mb[i] + ";");
            }
            myMemoryStream.Close();
            byte[] rmb = new Byte[1024];
            MemoryStream bMemoryStream = new MemoryStream(rmb);
            Console.WriteLine("容量=" + bMemoryStream.Capacity.ToString());
            Console.WriteLine("数据长度= " + bMemoryStream.Length.ToString());

            bMemoryStream.Close();
            Console.ReadLine();
        }
    }
}
