﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication59
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int recv; //客户端发送的信息的长度
            byte[] data = new byte[2014];//用于缓存客户端发出的信息
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);//本机预使用的ip和端口
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(10);
            Console.WriteLine("waiting for a client... ...");
            Socket client = newsock.Accept();//当有可用的客户端连接尝试时执行，并返回一个新的socket，用于与客户端之间的通信
            IPEndPoint clienttip = (IPEndPoint)client.RemoteEndPoint;
            Console.WriteLine("connect with client :" +clienttip.Address+"at port :"+clienttip.Port);
            string welcome = "welcome here!";
            data = Encoding.ASCII.GetBytes(welcome);
            client.Send(data, data.Length, SocketFlags.None);
            while(true)
            {
                data = new byte[1024];
                recv = client.Receive(data);
                Console.WriteLine("recv=" + recv);
                if(recv == 0)
                {
                    break;
                }
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
                client.Send(data, recv, SocketFlags.None);
            }
            Console.WriteLine("disconnect from " + clienttip.Address);
            client.Close();
            newsock.Close();
        }
    }
}
