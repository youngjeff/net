using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    delegate void DlgDoCalcDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            clac mycalc = new clac();

            mycalc.evtDoCalc += delegate
            {
                long lngFirstValue;
                long lngSecondValue;

                long lngSum;
                Console.WriteLine("请输入第1个进行运算的数: ");
                lngFirstValue = long.Parse(Console.ReadLine());

                Console.WriteLine("请输入第2个进行运算的数: ");
                lngSecondValue = long.Parse(Console.ReadLine());
                lngSum = lngFirstValue + lngSecondValue;
            };
                Console.WriteLine("触发加法运算事件... ");

                mycalc.DoCalc();
                Console.Read();
            }
        
    }
    class clac
    {
        public event DlgDoCalcDelegate evtDoCalc;

        public void DoCalc()
        {
            evtDoCalc();
        }
    }
}
