using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "   vbscript";
            string s2 = "    good";
            string a = s1.Trim() + s2.TrimStart();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
