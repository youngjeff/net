﻿using System;

class UsingProperty
{
    static void Main()
    {
        int intCompare;
        bool blnResult;
        Compare myCompare = new Compare();

        for(;;)
        {
            Console.Write("请输入比较的数值：");
            intCompare = int.Parse(Console.ReadLine());
            myCompare.pCNumber = intCompare;
            blnResult = myCompare.CompareResult();

            if (blnResult == false)
            {
                Console.WriteLine("{0} 大于{1} ", myCompare.ptheValue, myCompare.pCNumber);
            }
            else
                Console.WriteLine("{0} 小于 {1}",myCompare.ptheValue, myCompare.pCNumber);
        }
    }
    class Compare
    {
        private int theValue = 50;
        private int compareValue = 0;
        public int pCNumber = 0;

        public int pCNumber
        {
            get
            {
                return compareValue;
            }
            set
            {
                if (value < 0)
                {
                    compareValue = 0;
                }
                else
                    compareValue = value;
            }
        }

    }
}