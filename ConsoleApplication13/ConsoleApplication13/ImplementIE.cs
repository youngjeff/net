using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication13
{
    class ImplementIE : IEnumerable
    {
        int[] myInt = new int[32];
        int currentIndex = -1;

        public ImplementIE()
        {
            for(int i=0;i<32;i++)
            {
                myInt[i] = i * 10;
            }
        }
        public IEnumerator GetEnumerator()
        {
            ClsIEnumerator myClsIEnumerator = new ClsIEnumerator(this);
            return myClsIEnumerator;
        }
        class ClsIEnumerator : IEnumerator
        {
            ImplementIE myImplementIE;
            public ClsIEnumerator(ImplementIE myImplementIE)
            {
                this.myImplementIE = myImplementIE;
            }
            public object Current
            {
                get
                {
                    return myImplementIE.myInt[myImplementIE.currentIndex];
                }
            }
            public void Reset()
            {
                myImplementIE.currentIndex = -1;
            }
            public bool MoveNext()
            {
                myImplementIE.currentIndex++;
                if (myImplementIE.currentIndex >= myImplementIE.myInt.Length)
                {
                    return false;
                }
                else
                    return true;
            }
        }
    }
}
