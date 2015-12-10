using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
namespace ConsoleApplication41
{
    public class Program
    {
        [Serializable]
        private class ClsSerializable
        {
            public int intNumber = 254;
            public string strDemo = "This is a test string ";

            public long lngNumber = 123456;
        }
        
        public static void Main(string[] args)
        {
            Program mySerializable = new Program();
            ClsSerializable myClsSerializable = new ClsSerializable();

            mySerializable.SerializeBinary(myClsSerializable);
            mySerializable.SerializeSoap(myClsSerializable);
            mySerializable.PrintObject();

            Console.Read();
        }
        private void SerializeBinary(ClsSerializable o)
        {
            FileStream myFileStream = new FileStream("./text.txt", FileMode.Create);

            BinaryFormatter myBFormatter = new BinaryFormatter();
            myBFormatter.Serialize(myFileStream,o);
            Console.WriteLine("序列化完成，数据保存于文本文件text.txt");

            myFileStream.Close();
        }
        private void SerializeSoap(ClsSerializable o)
        {
            FileStream myFileStream = new FileStream("text1.txt", FileMode.Create);
            SoapFormatter mySoapFormatter = new SoapFormatter();

            Console.WriteLine("开始进行 SOAP 格式序列化...");
            mySoapFormatter.Serialize(myFileStream, o);
            Console.WriteLine("序列化完成，数据保存于文件文件text1.txt...");

            myFileStream.Close();
        }
        private ClsSerializable DeSerialize()
        {
            ClsSerializable o;
            FileStream myFileStream = new FileStream("text.txt", FileMode.Open);
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("开始还原序列化对象...");
            o = (ClsSerializable)myBinaryFormatter.Deserialize(myFileStream);
            Console.WriteLine("对象完成还原...");
            return o;
        }
        private void PrintObject()
        {
            Program mySerializable = new Program();
            ClsSerializable myNewClsSeriable = new ClsSerializable();
            Console.WriteLine("属性值 intNumber:{0} ", myNewClsSeriable.intNumber);
            Console.WriteLine("属性值 strDemo： {0} ", myNewClsSeriable.strDemo);
            Console.WriteLine("属性值 lngNumber:{0} ", myNewClsSeriable.lngNumber);

        }

    }
}
