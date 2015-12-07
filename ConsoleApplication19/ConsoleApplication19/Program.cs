using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            string threadName = "";
            threadName = Thread.CurrentThread.Name;
            Console.WriteLine("Thead: " + threadName);

            Thread.CurrentThread.Name = "主线程";
            threadName = Thread.CurrentThread.Name;
            Console.WriteLine("Thread:" + threadName);
            Console.ReadLine();
        }
    }
}
