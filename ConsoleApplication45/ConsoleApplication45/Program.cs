using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    delegate void DlgDoCalcDelegate();
    class Program
    {
        private void DoAdd()
        {
            AddMethod();
        }
        private void AddMethod()
        {
            long lngFirstValue;
            long lngSecondValue;

            long lngSum;
            Console.WriteLine("请输入第1个进行运算的数: ");
            lngFirstValue = long.Parse(Console.ReadLine());
            Console.WriteLine("请输入第2个进行运算的数: ");
            lngSecondValue = long.Parse(Console.ReadLine());
            lngSum = lngFirstValue + lngSecondValue;


            Console.WriteLine("{0}与{1}的和等于{2}", lngFirstValue,lngSecondValue, lngSum);
        }
        static void Main(string[] args)
        {
            Program myEventHandler = new Program();
            Clac myClac = new Clac();
            myClac.evtDoCalc += new DlgDoCalcDelegate(myEventHandler.DoAdd);
            Console.WriteLine("触发加法运算事件...");

            myClac.DoCalc();
            Console.Read();
        }

    }
    class Clac
    {
        public event DlgDoCalcDelegate evtDoCalc;
        public void DoCalc()
        {
            evtDoCalc();
        }
    }
}
