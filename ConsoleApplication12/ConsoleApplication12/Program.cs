using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication12
{
    class Program
    {
        public  static void Main(string[] args)
        {
            SortedList mySortedList = new SortedList();

            for(int i=0;i<10;i++)
            {
                mySortedList.Add("key" + i, "value" + i);
            }
            WriteList(mySortedList);
            Console.ReadLine();
        }
        public static void WriteList(SortedList mySortedList)
        {
            Console.WriteLine("\n以下为集合所包含的对象元素key/value!!\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("mysortedlist[{0}]的值为:{1}", mySortedList.GetKey(i),mySortedList["key" + i]);
                
            }
            Console.WriteLine("\n以下使用索引器--取出集合中的对象！！\n");

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("索引{0}的值为:{1}", i, mySortedList.GetByIndex(i).ToString());
            }
            Console.WriteLine();
        }
    }
}
