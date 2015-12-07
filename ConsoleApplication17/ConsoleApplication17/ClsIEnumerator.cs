using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApplication17
{
     class ClsIEnumerator<T> : IEnumerator<T>
    {
        ImplementIE<T> myImplementIE;
        public ClsIEnumerator(ImplementIE<T> myImplementIE)
        {
            this.myImplementIE = myImplementIE;
        }
        
        

        public T Current
        {
            get
            {
                return myImplementIE.myInt[myImplementIE.currentIndex];
            }
        }
        object System.Collections.IEnumerator.Current
        {
            get
            {
                return Current;
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
                return false;
            else
                return true;
        }
        public void Dispose() { }
    }
}
