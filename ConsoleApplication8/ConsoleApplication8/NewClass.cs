using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class NewClass
    {
        private string theMessage = "hello C# 2.0";
        private string theotherMessage = "welcome to C# 2.0 world";
        protected void showMessage()
        {
            Console.WriteLine(theMessage);
        }
        void showAnotherMessage()
        {
            Console.WriteLine(theotherMessage);
        }
    }
}
