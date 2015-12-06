using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Square : IMeasure
    {
        public void Length(double length)
        {
            double squareLength;
            squareLength = 4 * length;
            Console.WriteLine("边长为{0}的正方形周长= {1} ", length, squareLength);
        }
        public void Area(double length)
        {
            double area;
            area = Math.Pow(length, 3);
            Console.WriteLine("边长为{0}的立方体体积={1}", length, area);
        }
        public void Volume(double length)
        {
            double volume;
            volume = Math.Pow(length, 3);
            Console.WriteLine("边长为{0}的圆形周长={1}", length, volume);
        }

    }
    
}
