using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementIE myImplementIE = new ImplementIE();
            IEnumerator myIEnumerator = myImplementIE.GetEnumerator();
            while (myIEnumerator.MoveNext())
            {
                int i = (int)myIEnumerator.Current;
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
