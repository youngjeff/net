using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue theQueue = new Queue();
            theQueue.Enqueue("ABCDE");
            theQueue.Enqueue(10);

            object firstObject = theQueue.Dequeue();
            object secondObjct = theQueue.Dequeue();

            string strValue = firstObject.ToString();
            int intValue = int.Parse(secondObjct.ToString());

            Console.WriteLine("第一个集合对象:" + strValue);
            Console.WriteLine("第二个集合对象:" + intValue);

            Console.ReadLine();
        }
    }
}
