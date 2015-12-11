using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsISerialiation myClsIs = new ClsISerialiation();
            FileStream myFilestream = new FileStream("text.txt", FileMode.Create);
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();

            myBinaryFormatter.Serialize(myFilestream, myClsIs);
            myClsIs = null;
            myFilestream.Close();
            myFilestream = new FileStream("text.txt", FileMode.Open);
            myBinaryFormatter = new BinaryFormatter();
            myClsIs = (ClsISerialiation)myBinaryFormatter.Deserialize(myFilestream);
            myFilestream.Close();
            Console.WriteLine(myClsIs.message);
            Console.WriteLine(myClsIs.intNumber);
            Console.WriteLine(myClsIs.lngTest);
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine(myClsIs.intArrayX[i]);

            }
            Console.Read();
        }
    }
    [Serializable]
    public class ClsISerialiation : ISerializable
    {
        public int intNumber = 1000;
        public string message = "这是测试字符串";
        public long lngTest;
        public int[] intArrayX = new int[10];
        public int[] intArrayY = new int[10];
        public ClsISerialiation()
        {
            ChangeMmberValue();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("intNumber", intNumber);
            info.AddValue("message", message);
            info.AddValue("intArrayX", intArrayX);

        }
        public ClsISerialiation(SerializationInfo info,StreamingContext context)
        {
            intNumber = (int)info.GetValue("intNumber", typeof(int));
            message = (string)info.GetValue("message", typeof(string));
            intArrayX = (int[])info.GetValue("intArrayX", typeof(int[]));
        }
        void ChangeMmberValue()
        {
            for(int i=0;i < 10;i++)
            {
                intArrayX[i] = i * 100;

            }
            intNumber = 2000;
            message = "这是修正过的字符串";

        }
    }
}
