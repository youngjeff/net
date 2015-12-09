using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Dns.GetHostName();
            Console.WriteLine("主机名称：{0} ", s);
            Console.ReadLine();
        }
    }
}
