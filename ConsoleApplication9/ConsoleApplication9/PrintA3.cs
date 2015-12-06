using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class PrintA3 : PrintReport
    {
        public override void PrintStart()
        {
            Console.WriteLine("报表开始打印...!!");
            Console.WriteLine("打印A3尺寸报表...!!!");
            Console.WriteLine("A3尺寸报表打印完成...!!!");
            FinishedWork("A3");
        }
    }
}
