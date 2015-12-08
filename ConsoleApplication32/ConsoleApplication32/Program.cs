using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication32
{
    class Program
    {
        FileStream myFileStream;
        double lngNumber = 100;
        static void Main(string[] args)
        {
            Program myAsynchronousIO = new Program();
            myAsynchronousIO.longProcessWrite();
            Console.Read();
        }
        public void longProcessWrite()
        {
            byte[] b = new byte[100];
            for(int i=0;i<lngNumber;i++)            
                b[i] = (byte)i;
                Console.WriteLine("写入大量数据....");

                AsyncCallback myAsyncCallback = new AsyncCallback(WriteEnd);
                myFileStream = new FileStream("text1.txt",FileMode.Create);
                myFileStream.BeginWrite(b, 0, b.Length, myAsyncCallback, null);
                Console.WriteLine("目前正在将大量数据写入文件" + "text.txt" + "!!");
            

        }
        public void WriteEnd(IAsyncResult asyncResult)
        {
            Console.WriteLine("文件写入完毕!!");
        }
    }
}
