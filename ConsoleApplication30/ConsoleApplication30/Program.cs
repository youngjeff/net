using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace ConsoleApplication30
{
    class Program
    {
        StreamReader myStreamReader;
        public static void Main(string[] args)
        {
            Program myTextRead = new Program();
            string strReadFile;
            Console.WriteLine("输入欲读取的文件名称: ");
            strReadFile = Console.ReadLine();

            myTextRead.myStreamReader = new StreamReader(strReadFile);
            Console.WriteLine("\n 以下为所要读取的文件内容...");
            myTextRead.ReadText();

            Console.WriteLine("数据读取完毕，关闭数据流...");
            myTextRead.myStreamReader.Close();
            Console.Read();
        }
        private void ReadText()
        {
            string strBufferText;
            do
            {
                strBufferText = myStreamReader.ReadLine();
                Console.WriteLine(strBufferText);
            } while (strBufferText != null);
        }
    }
}
