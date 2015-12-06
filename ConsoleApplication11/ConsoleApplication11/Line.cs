using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Line : IMeasureLength
    {
        public void Length(double length)
        {
            Console.WriteLine("线条长度={0}", length);
        }
    }
}
