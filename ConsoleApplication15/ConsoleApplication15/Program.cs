using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;
            int thirdNumber = 30;
            int forthNumber = 40;
            int fifthNumber = 50;

            Stack myStack = new Stack();
            Console.WriteLine("使用方法push 将对象压入栈中：\n");

            Console.WriteLine("加入第一个数10:");
            myStack.Push(firstNumber);
            Console.WriteLine("加入第二个数20:");
            myStack.Push(secondNumber);
            Console.WriteLine("加入第一个数30:");
            myStack.Push(thirdNumber);
            Console.WriteLine("加入第一个数40:");
            myStack.Push(forthNumber);
            Console.WriteLine("加入第二个数50:");
            myStack.Push(fifthNumber);
            Console.WriteLine();
            Console.WriteLine("使用方法peek从堆栈获取对象：\n");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(myStack.Peek());
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine("堆栈内当前的对象数目:{0}\n", myStack.Count);

            Console.WriteLine("使用方法Pop从堆栈中获取对象，并且将其移除\n");
            
            Console.WriteLine("堆栈内当前的对象数目:{0}\n", myStack.Count);
            Console.WriteLine("使用方法Pop从堆栈中取得对象，并且将其移除:\n");
            Console.WriteLine("从堆栈内当前的对象数目:{0} \n", myStack.Count);
            Console.ReadLine();
        }
    }
}
