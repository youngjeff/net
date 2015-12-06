using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            const double length = 10;
            Square mysquare = new Square("正方形", length);
            mysquare.GetResult();
            Console.WriteLine();
            Globe myGlobe = new Globe("圆形", length);
            myGlobe.GetResult();

            Console.ReadLine();
        }
    }
}
