using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入所要解析的主机名称:");
                string pHostName = Console.ReadLine();//读取网站名
                IPHostEntry myAddress = Dns.GetHostEntry(pHostName);

                Console.WriteLine("{0} 所对应的Ip地址如下: ", pHostName);
                IPAddress[] myIPAddress = myAddress.AddressList;//将获取的ip地址放到myIpAddress
                foreach(IPAddress add in myIPAddress)
                {
                    Console.WriteLine(add);
                }
                Console.WriteLine("输入所要解析的Ip地址: ");
                string pAddress = Console.ReadLine();

                IPHostEntry myHostName = Dns.GetHostEntry(pAddress);
                Console.WriteLine("{0} 所对应的主机名称如下: ", pAddress);
                Console.WriteLine(myHostName.HostName.ToString());
            }
            catch ( SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
