using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入网址: ");
                string myAddress = Console.ReadLine();

                WebRequest myWebRequest = WebRequest.Create(myAddress);
                WebResponse myWebResponse = myWebRequest.GetResponse();

                Stream myStream = myWebResponse.GetResponseStream();
                byte[] mybyte = new byte[1024];//1M 2进制数据
                string pagecontent = "";
                int read1 = 0;
                do
                {
                    read1 = myStream.Read(mybyte, 0, 1024);
                    pagecontent += Encoding.UTF8.GetString(mybyte, 0, 1024);//offset long
                } while (read1 > 0);
                Console.WriteLine();//输入一空格
                Console.WriteLine(" 以下为获取的网页内容 : ");
                Console.WriteLine(pagecontent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
