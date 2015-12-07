using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myUsingSleep = new Program();
            myUsingSleep.StartThread();
        }
        private void StartThread()
        {
            ThreadStart myThreadStart = new ThreadStart(PrintNumber);
            Thread myThread = new Thread(myThreadStart);
            myThread.Start();
            Console.ReadLine();
        }
        public void PrintNumber()
        {
            for(int i=0;i<200;i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "循环开始执行迄今第" + i + "次");
                if(i == 100)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "循环暂停5秒钟!!");
                    Thread.Sleep(5000);//暂停线程
                }
                
                
            }
        }
    }
}
