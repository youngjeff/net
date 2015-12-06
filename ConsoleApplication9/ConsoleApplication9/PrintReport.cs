using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class PrintReport
    {
        public PrintReport()
        {
            Console.WriteLine("报表打印程序启动。。。。");
        }
        public virtual void PrintStart()
        {
            Console.WriteLine("报表开始打印...!");
            Console.WriteLine("打印标准尺寸报表。。。");
            Console.WriteLine("工作完成");
            FinishedWork("标准");
        }
        protected void FinishedWork(string reportType)
        {
            Console.WriteLine("{0} 报表打印完成...!!!", reportType);
            Console.WriteLine("清除队列工作...!!");
        }

    }
}
