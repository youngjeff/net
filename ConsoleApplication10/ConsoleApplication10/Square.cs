using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Square : TemplateClass
    {
        public Square(string shape,double length):base (shape,length)
        { }
        protected override void Length(double length)
        {
            double squareLength;
            squareLength = 4 * length;
            Console.WriteLine("边长为{0}的正方形周长= {1}",length,squareLength);
        }
        protected override void Area(double length)
        {
            double area;
            area = Math.Pow(length, 2);
            Console.WriteLine("边长为{0}的立方体体积={1}",length,area);
        }
        protected override void Volume(double length)
        {
            double volume;
            volume = Math.Pow(length, 3);
            Console.WriteLine("边长为{0}的立方体体积={1} ",length, volume);
        }
    }
}
