using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            long length;
            long width;
            long height;

            Console.WriteLine("请输入长度:");
            length = long.Parse(Console.ReadLine());
            Console.WriteLine("请输入宽度: ");
            width = long.Parse(Console.ReadLine());
            Console.WriteLine("请输入高度: ");
            height = long.Parse(Console.ReadLine());

            GetResult myGetResult = new GetResult(height, length, width);

            Measure myMeasure = new Measure();
            GetResult.MyDelegate myGRDelegate;
            if(length == width)
            {
                myGRDelegate = new GetResult.MyDelegate(myMeasure.MeasureSquare);
            }
            else
            {
                myGRDelegate = new GetResult.MyDelegate(myMeasure.MeasureRectangle);

            }

            myGetResult.Calc(myGRDelegate);
            Console.ReadLine();

        }
    }
    public class GetResult
    {
        long height;
        long length;
        long width;

        public GetResult(long height,long length,long width)
        {
            this.height = height;
            this.length = length;
            this.width = width;
        }
        public delegate double MyDelegate(long length, long width);
        public void Calc(MyDelegate pmyDelegate)
        {
            double volume;
            volume = pmyDelegate(length, width) * height;
            Console.WriteLine("高度为{0}，则体积为{1}", height, volume);
        }
    }
    public class Measure
    {
        public double MeasureSquare(long length,long width)
        {
            double squareLength;
            double squareSurface;
            squareLength = 4 * length;
            squareSurface = Math.Pow(length, 2);

            Console.WriteLine("长{0}宽{1}为一正方形，其周长{2}，面积{3} :",length,width,squareLength,squareSurface);
            return squareSurface;
        }
        public double MeasureRectangle(long lenght,long width)
        {
            double RectangleLength;
            double RectangleSurface;
            RectangleLength = 2 * (lenght + width);
            RectangleSurface = lenght * width;

            Console.Write("长{0} 宽{1} 的长方形周长为{2}，面积为{3}:", lenght, width, RectangleLength, RectangleSurface);
            return RectangleSurface;
        }
    }
    
}
