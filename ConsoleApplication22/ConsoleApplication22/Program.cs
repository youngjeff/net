using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myUsingIsAlive = new Program();
            Thread myThread = new Thread(new ThreadStart(myUsingIsAlive.justSleep));//trheadStart 表示线程上执行的方法
            myThread.Start();
            do
            {
                Thread.Sleep(1000);
                Console.WriteLine("myThread 线程当前状态{0} ", myThread.IsAlive.ToString());
                Console.WriteLine("..........");
            } while (myThread.IsAlive);

            myThread.Join();
            Console.WriteLine("mythread 线程结束!!");
            Console.ReadLine();
        }
        void justSleep()
        {
            Console.WriteLine("开始启动线程的执行!!");
            Console.WriteLine("暂停线程myThread 执行5秒！！");
            Console.WriteLine("=========================");

            Thread.Sleep(5000);
        }
    }
}
