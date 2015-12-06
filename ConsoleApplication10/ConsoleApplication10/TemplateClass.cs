using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
     abstract class TemplateClass
    {
        public double length = 0;
        public TemplateClass(string shape,double r)
        {
            this.TheShape(shape);
            this.length = r;
        }
        private void TheShape(string shape)
        {
            Console.WriteLine("目测的形状{0}", shape);
        }
        public void GetResult()
        {
            Length(length);
            Area(length);
            Volume(length);
        }
        abstract protected void Length(double length);
        abstract protected void Area(double length);
        abstract protected void Volume(double length);
    }
}
