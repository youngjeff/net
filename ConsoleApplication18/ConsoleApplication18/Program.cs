using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApplication18
{
    public class Program
    {
        static void Main(string[] args)
        {
            ImplementIE<string> myImplementIE = new ImplementIE<string>();

            myImplementIE.AddElement("A");
            myImplementIE.AddElement("B");
            myImplementIE.AddElement("C");
            myImplementIE.AddElement("D");
            myImplementIE.AddElement("E");

            foreach(string s in myImplementIE)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine("");
            IEnumerator<string> myIEnumerator = myImplementIE.GetEnumerator();
            while (myIEnumerator.MoveNext())
            {
                string s = myIEnumerator.Current;
                Console.Write(s + "\t");
            }
            Console.ReadLine();
        }
    }
    
}
