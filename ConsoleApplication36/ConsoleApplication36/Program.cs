using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace ConsoleApplication36
{
    class Program
    {
        NetworkStream myNetworkStream;
        TcpClient myTcpClient;
        static void Main(string[] args)
        {
            Program myNetworkClient = new Program();
            Console.WriteLine("输入连接计算机名称: ");
            string hostName = Console.ReadLine();
            Console.WriteLine("输入连接通信接口: ");
            int connectPort = int.Parse(Console.ReadLine());
            myNetworkClient.myTcpClient = new TcpClient();
            try
            {
                myNetworkClient.myTcpClient.Connect(hostName, connectPort);
                Console.WriteLine("联机成功!!\n");
            }
            catch
            {
                Console.WriteLine("主机{0} 通信端口{1} 无法连接！！", hostName, connectPort);
                return;
            }
            
        }
        void writeData()
        {
            string strTest = "this is a test string !!";
            Byte[] myBytes = Encoding.ASCII.GetBytes(strTest);

            Console.WriteLine("创建网络数据流！！");
            myNetworkStream = myTcpClient.GetStream();

            Console.WriteLine("将字符串写入数据流!!");
            myNetworkStream.Write(myBytes, 0, myBytes.Length);
        }
        void ReadData()
        {
            Console.WriteLine("从网络数据流读取数据!!");
            int bufferSize = myTcpClient.ReceiveBufferSize;
            byte[] myBufferedBytes = new byte[bufferSize];
            myNetworkStream.Read(myBufferedBytes, 0, bufferSize);
            Console.WriteLine(Encoding.ASCII.GetString(myBufferedBytes, 0, bufferSize));
        }
    }
}
