using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    public delegate string ProcessDelegate(string s1, string s2);
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            string r1 = t.Process("Text1", "Text2", new ProcessDelegate(t.Process1));
            string r2 = t.Process("Text1", "Text2", new ProcessDelegate(t.Process2));
            string r3 = t.Process("Text1", "Text2", new ProcessDelegate(t.Process3));

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.Read();
        }
    }
    public class Test
    {
        public string Process(string s1,string s2,ProcessDelegate process)
        {
            return process(s1, s2);
        }
        public string Process1(string s1,string s2)
        {
            return s1 + s2;
        }
        public string Process2(string s1,string s2)
        {
            return s1 + Environment.NewLine + s2;
        }
        public string Process3(string s1,string s2)
        {
            return s2 + s1;
        }
    }
}
