using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Globe : IMeasure
    {
        public void Length(double r)
        {
            double globeLength;
            globeLength = 4 * Math.PI * r;
            Console.WriteLine("半径为{0}的圆形周长={1}", r, globeLength);
        }
        public void Area(double r)
        {
            double area;
            area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("半径为{0}的圆形面积=", r, area);
        }
        public void Volume(double r)
        {
            double volume;
            volume = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("半径为{0}的球体体积={1} ", r, volume);
        }

    }
}
