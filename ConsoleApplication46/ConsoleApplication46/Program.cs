using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            long speed;
            CheckSpeed myCheckSpeed = new CheckSpeed();
            DoSomeThing myDoSomeThing = new DoSomeThing();
            Console.Write("目前行车速度: ");
            speed = long.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            myCheckSpeed.myEvent += new SpeedCheckhandle(myDoSomeThing.SlowDown);
            myCheckSpeed.CheckSpeedLimit(speed);
            Console.ReadLine();
        }
    }
    public class SpeedCheckEventArgs : EventArgs
    {
        private long speed;
        public SpeedCheckEventArgs(long speed)
        {
            this.speed = speed;
        }
        public long getSpeed
        {
            get
            {
                return speed;
            }
        }
        public string WarningMessage
        {
            get
            {
                return ("警告: 行车超过限速!!");
            }
        }
    }
    public delegate void SpeedCheckhandle(object sender, SpeedCheckEventArgs e);
    public class CheckSpeed
    {
        public event SpeedCheckhandle myEvent;

        public void CheckSpeedLimit(long speed)
        {
            if(speed > 60)
            {
                SpeedCheckEventArgs speedsArgs = new SpeedCheckEventArgs(speed);
                myEvent(this, speedsArgs);
            }
            else
            {
                Console.WriteLine("您目前速度正常");
            }
        }
    }
    public class DoSomeThing
    {
        public void SlowDown(object sender,SpeedCheckEventArgs e)
        {
            Console.WriteLine(e.WarningMessage);
            Console.WriteLine("您目前车速{0}已超速，请踩下刹车，降低速度，避免危机！！",e.getSpeed);
            Console.WriteLine("正常行车速度请降至60公里/小时以下！！");
        }

    }

}
