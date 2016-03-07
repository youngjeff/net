﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApplication60
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            Socket newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Console.Write("please input the the server ip");
            string ipadd = Console.ReadLine();
            Console.WriteLine();
            Console.Write("please input the server port");
            int port = Convert.ToInt32(Console.ReadLine());
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);//服务器的ip和端口
            try
            {
                newclient.Connect(ie);
            }
            catch(SocketException e)
            {
                Console.WriteLine("unable to connnect to server");
                Console.WriteLine(e.ToString());
                return;
            }
            int recv = newclient.Receive(data);
            string stringdata = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine(stringdata);
            while(true)
            {
                string input = Console.ReadLine();
                if(input =="exit")
                {
                    break;
                }
                newclient.Send(Encoding.ASCII.GetBytes(input));
                data = new byte[1024];
                recv = newclient.Receive(data);
                stringdata = Encoding.ASCII.GetString(data, 0, recv);
                Console.WriteLine(stringdata);
            }
            Console.WriteLine("disconnect from sercer...");
            newclient.Shutdown(SocketShutdown.Both);
            newclient.Close();
        }
    }
}
