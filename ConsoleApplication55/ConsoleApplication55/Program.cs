using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    //public delegate string ProcessDelegate(string s1,string  s2);
    public delegate string ProcessDelegate<T, S>(T s1, S s2);
    class Program
    {
       
        static void Main(string[] args)
        {
            //ProcessDelegate pd = new ProcessDelegate(new Test().Process);
            ProcessDelegate<string,int> pd = new ProcessDelegate<string, int>(new Test().Process);
            Console.WriteLine(pd("Test1", 100));
            Console.Read();
        }
    }

    public class Test
    {
        public string Process(string s1,int s2)
        {
            return s1 + s2;
        }
    }
}
