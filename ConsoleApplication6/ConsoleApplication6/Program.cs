 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class UsingStruct
    {
        static void Main(string[] agrs)
        {
            ClassStruct theClassStruct;
            theClassStruct.student = "jeff";
            theClassStruct.stuNumber = "000000";
            Console.WriteLine("学生：" + theClassStruct.student + "\t" + "学号" + theClassStruct.stuNumber);
            Console.ReadLine();
        }
    }
    public struct ClassStruct
    {
        public string student;
        public string stuNumber;

        public ClassStruct(string student,string stuNumber)
        {
            this.student = student;
            this.stuNumber = stuNumber;
        }
    }
 }
