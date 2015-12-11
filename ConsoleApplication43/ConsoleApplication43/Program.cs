using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            long length1 = 10;
            long length2 = 15;
            MyDelegate myDelegate1 = new MyDelegate(Measure.Square);
            MyDelegate myDelegate2 = new MyDelegate(Measure.Circle);//将代理转为相应的方法

            Console.WriteLine("边长为{0}的正方形面积为:{1}", length1, myDelegate1(length1).ToString());
            Console.WriteLine("边长为{0}的圆形面积为{1}", length2, myDelegate2(length2).ToString());
            Console.Read();
        }
    }
    public delegate double MyDelegate(long length);
    public class Measure
    {
        public static double Square(long length)
        {
            double area;
            area = Math.Pow(length, 2);
            return (area);
        }
        public static double Circle(long length)
        {
            double area;
            area = (4 / 3) * Math.PI * Math.Pow(length, 3);
            return (area);
        }
    }
    
}
