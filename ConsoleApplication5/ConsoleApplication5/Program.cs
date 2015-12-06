using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class UsingPropertyAccl
    {
        static void Main(string[] args)
        {
            MemberInformation theMemberInformation = new MemberInformation();
            int days = theMemberInformation.dayAllow;
            Console.WriteLine("会员到期天数：" + days.ToString());

            DaysAcess theDayAccess = new DaysAcess();
            theDayAccess.setDays(250);
            days = theDayAccess.getDays();
            Console.WriteLine("会员到期天数:" +days.ToString());
            Console.ReadLine();

        }
    }
    class MemberInformation
    {
        private int days = 100;
        public int dayAllow
        {
            get
            {
                return days;
            }
            protected set
            {
                if (value < 0)
                {
                    days = 100;
                }
                else
                    days = value;
            }
        }
    }
    class DaysAcess : MemberInformation
    {
        public void setDays(int days)
        {
            this.dayAllow = days;
        }
        public int getDays()
        {
            return this.dayAllow;
        }
    }
}
