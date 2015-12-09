using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入网址 : ");
                string myAddress = Console.ReadLine();
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(myAddress);
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                Stream myStream = myHttpWebResponse.GetResponseStream();
                byte[] mybyte = new byte[1024];
                string pagecontent = "";
                int read1 = 0;

                do
                {
                    read1 = myStream.Read(mybyte, 0, 1024);
                    pagecontent += Encoding.UTF8.GetString(mybyte, 0, 1024);
                } while (read1 > 0);
                Console.WriteLine();
                Console.WriteLine(" 以下为所获得的网页内容 : \n");
                Console.WriteLine(pagecontent);

                Console.WriteLine(myHttpWebResponse.Headers);
                Console.WriteLine(myHttpWebResponse.ResponseUri);

                myHttpWebResponse.Close();
                myStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
//程序自带换行符