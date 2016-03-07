using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 test = new Class1();
            string msg = test.msgShow();
            Console.WriteLine(msg);
            Console.Read();
        }
    }
}
