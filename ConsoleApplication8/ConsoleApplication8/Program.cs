using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program : NewClass 
    {
        static void Main(string[] args)
        {
            Program theprogram = new Program();
            theprogram.showMessage();
            NewClass newclass = new NewClass();
            newclass.showAnotherMessage();
            Console.ReadLine();
        }
    }
}
