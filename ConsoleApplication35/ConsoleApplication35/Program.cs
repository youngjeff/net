using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入主机名称: ");
            string hostName = Console.ReadLine();

            Console.WriteLine("输入开始扫面通信端口: ");
            int startPort = int.Parse(Console.ReadLine());
            Console.WriteLine("输入结束扫描通信端口: ");
            int endPort = int.Parse(Console.ReadLine());
            for (int i = startPort; i <= endPort; i++)
            {
                TcpClient myTcpClient = new TcpClient();
                try
                {
                    myTcpClient.Connect(hostName, i);
                    Console.WriteLine("Port" + i.ToString() + "目前打开!!");
                    myTcpClient.Close();
                }
                catch (SocketException e)
                {
                    Console.Write(e.Message);
                    Console.WriteLine("post" + i.ToString() + "关闭！");
                }
            }
            Console.WriteLine("指定通信端口扫描完成!!");
            Console.WriteLine("请按[Enter] 离开!!");
            Console.ReadLine();
        }
    }
}
