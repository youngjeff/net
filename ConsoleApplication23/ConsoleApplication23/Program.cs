using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以下开始将工作排入线程管理工作队列!!");
            Console.WriteLine("*******************");

            for(int i=0;i<4;i++)
            {
                WaitCallback myWaitCallback = new WaitCallback(WorkItem);
                ThreadPool.QueueUserWorkItem(myWaitCallback, i + 1);
                Thread.Sleep(1000);
            }
            Console.WriteLine("**************************");

            for(int i=0;i<4;i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(LongWorkItem), i + 1);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
        public static void WorkItem(object i)
        {
            string itemName;
            itemName = "使用线程编号Thread ID# = " + Thread.CurrentThread.GetHashCode();
            Console.WriteLine("这是第1组被排入队列的第{0}个工作，{1}", i, itemName);
            Console.WriteLine("此工作线程已结束!!");
        }
        public static void ShortWorkItem(object i)
        {
            string itemName;
            itemName = "使用线程编号Thread ID# = " + Thread.CurrentThread.GetHashCode();
            Console.WriteLine("这是第2组被排入队列的第{0}个工作，{1}", i, itemName);
            Console.WriteLine("此工作线程暂停两秒");
            Thread.Sleep(2000);
        }
        public static void LongWorkItem(object i)
        {
            string itemName;
            itemName = "使用线程编号Thread ID# = " + Thread.CurrentThread.GetHashCode();
            Console.WriteLine("这是第3组被排入队列的第{0}个工作，{1}", i, itemName);
            Console.WriteLine("此工作线程暂停10秒");
            Thread.Sleep(10000);
        }
    }
}
