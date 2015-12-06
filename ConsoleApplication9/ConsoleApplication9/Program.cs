using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int reportType;
                Console.WriteLine("请输入所要打印的报表规格！！");
                Console.Write("1.标准 /2.A4 /3. A3 ? ");
                reportType = int.Parse(Console.ReadLine());
                Console.WriteLine("");//空一格

                switch(reportType)
                {
                    case 1:
                        PrintReport myPrintReport = new PrintReport();
                        myPrintReport.PrintStart();
                        break;
                    case 2:
                        PrintA4 myprintA4 = new PrintA4();
                        myprintA4.PrintStart();
                        break;
                    case 3:
                        PrintA3 myprintA3 = new PrintA3();
                        myprintA3.PrintStart();
                        break;
                }
                Console.WriteLine("");
            } while (true);
        }
    }
}
