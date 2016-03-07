using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    public delegate void ProcessDelegate(object sender, EventArgs e); //
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            Test t = new Test();
            t.ProcessEvent += new ProcessDelegate(t_ProcessEvent);
            Console.WriteLine(t.Process());

            Console.Read();
        }

        static void t_ProcessEvent(object sender,EventArgs e)
        {
            Test t = (Test)sender;
            t.Text1 = "Hello";
            t.Text2 = "world";
        }
    }
    public class Test
    {
        private string s1;

        public string Text1
        {
            get { return s1; }
            set { s1 = value; }
        }
        private string s2;
        public string Text2
        {
            get { return s2; }
            set { s2 = value; }
        }

        public event ProcessDelegate ProcessEvent;
        void ProcessAction(object sender,EventArgs e)
        {
            if(ProcessEvent == null)
            {
                ProcessEvent += new ProcessDelegate(t_ProcessEvent);
               
            }
            ProcessEvent(sender, e);
        }
        //如果没有自己指定关联方法，将会调用该方法抛出错误
         void t_ProcessEvent(object sender, EventArgs e)
        {
            throw new Exception("The method or operation is not implemented");
        }
        void OnProcess()
        {
            ProcessAction(this, EventArgs.Empty);
        }
        public string Process()
        {
            OnProcess();
            return s1 + s2;
        }
    }
}
