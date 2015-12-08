using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication29
{
    class Program
    {
        FileStream FileReadStream;
        FileStream FileWriteStream;
        BufferedStream myBufferedStreamInput;
        BufferedStream myBufferedStreamOutPut;
        static void Main(string[] args)
        {
            string strReadFile;
            string strWriteFile;

            Console.WriteLine("输入欲读取的文件名称: ");
            strReadFile = Console.ReadLine();
            Console.WriteLine("输入欲写出的文件名称 :");
            strWriteFile = Console.ReadLine();

            Program myBufferedIO = new Program();
            myBufferedIO.CreateStream(strReadFile, strWriteFile);

            Console.WriteLine("开始读取文件...");
            myBufferedIO.AccessData();
            Console.WriteLine("文件写入完成...");
            myBufferedIO.CloseStream();
            Console.Read();

        }
        private void CreateStream(string strReadFile,string strWriteFile)
        {
            FileReadStream = new FileStream(strReadFile, FileMode.Open, FileAccess.Read);
            FileWriteStream = new FileStream(strWriteFile, FileMode.Create, FileAccess.Write);
            myBufferedStreamInput = new BufferedStream(FileReadStream);
            myBufferedStreamOutPut = new BufferedStream(FileWriteStream);

        }
        private void AccessData()
        {
            byte[] byteBuffer = new byte[16];
            int intByte = 0;
            do
            {
                intByte = myBufferedStreamInput.Read(byteBuffer, 0, 16);
                myBufferedStreamOutPut.Write(byteBuffer, 0, intByte);
                myBufferedStreamInput.Flush();//清空缓冲区，并把缓冲区里的数据放入文件设备里
                myBufferedStreamOutPut.Flush();
                Console.WriteLine(intByte);
            } while (intByte > 0);
        }
        private void CloseStream()
        {
            FileReadStream.Close();
            FileWriteStream.Close();
            myBufferedStreamInput.Close();
            myBufferedStreamOutPut.Close();
        }
    }
}
