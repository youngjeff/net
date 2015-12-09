using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.IPAddress theIPAddress;
            theIPAddress = System.Net.IPAddress.Parse("127.0.0.1");
            TcpListener myTcpListener = new TcpListener(theIPAddress, 36000);
            myTcpListener.Start();
            Console.WriteLine("通信端口36000 等待客户端联机...!!");
            Socket mySocket = myTcpListener.AcceptSocket();
            do
            {
                try
                {
                    if (mySocket.Connected)
                    {
                        int dataLength;
                        Console.WriteLine("联机成功!!");
                        byte[] myBufferBytes = new byte[1000];

                        dataLength = mySocket.Receive(myBufferBytes);

                        Console.WriteLine("接收到的数据长度：{0} \n ", dataLength.ToString());
                        Console.WriteLine("取出客户端写入网络数据流的数据内容!!");
                        Console.WriteLine(Encoding.ASCII.GetString(myBufferBytes, 0, dataLength) + "\n");
                        Console.WriteLine("按下[Enter] 将数据返回客户端!!");

                        Console.ReadLine();
                        mySocket.Send(myBufferBytes, myBufferBytes.Length, 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    mySocket.Close();
                    break;
                }
            } while (true);
        }
    }
}
