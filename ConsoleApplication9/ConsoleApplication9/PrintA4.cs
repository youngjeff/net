using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class PrintA4 : PrintReport
    {
        public override void PrintStart()
        {
            Console.WriteLine("报表开始打印...!!");
            Console.WriteLine("打印A4尺寸报表...");
            FinishedWork("A4 ");
        }
    }
}
