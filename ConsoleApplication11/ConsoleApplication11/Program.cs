using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mysquare = new Square();
            if(mysquare is IMeasure)
            {
                IMeasure myIMeasure = (IMeasure)mysquare;
                myIMeasure.Area(5);
                myIMeasure.Length(5);
                myIMeasure.Volume(5);
            }
            Console.WriteLine("");

            Globe myGlobe = new Globe();
            if(myGlobe is IMeasure )
            {
                IMeasure myIMeasure = (IMeasure)myGlobe;
                myIMeasure.Area(5);
                myIMeasure.Length(5);
                myIMeasure.Volume(5);
            }
            Console.WriteLine("");

            Line myLine = new Line();
            if(myLine is IMeasure)
            {
                IMeasureLength myIMeasureLength = (IMeasureLength)myLine;
                myIMeasureLength.Length(100);

            }
            Console.ReadLine();
          }
        }
    
    interface IMeasure
    {
        void Length(double length);
        void Area(double length);
        void Volume(double length);
    }
    interface IMeasureLength
    {
        void Length(double length);
    }

}