using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myCreateThreading = new Program();
            myCreateThreading.Start();
            Console.WriteLine("离开请按[ENTER]!!");
            Console.Read();
        }
        private void Start()
        {
            ThreadStart myThreadStart1 = new ThreadStart(PrintOddNumber);
            Thread Threading1 = new Thread(myThreadStart1);
            Threading1.Name = "A Thread";

            ThreadStart myThreadStart2 = new ThreadStart(PrintNumber);
            Thread Threading2 = new Thread(myThreadStart2);
            Threading2.Name = "B Thread";

            Threading1.Start();
            Threading2.Start();
        }
        private void PrintOddNumber()
        {
            for(int i=1;i<1000;i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("线程{0} 输出奇数{1}",Thread.CurrentThread.Name, i);
            }
        }
        private void PrintNumber()
        {
            for(int i=1;i<1000;i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine("线程为{0}输出偶数{1}", Thread.CurrentThread.Name, i);
                }
            }
        }
    }
}
