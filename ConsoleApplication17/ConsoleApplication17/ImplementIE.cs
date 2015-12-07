using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication17
{
    public class ImplementIE<T> : IEnumerable<T>
    {
        public T[] myInt = new T[5];
        public int currentIndex = -1;

        public void AddElement(T TElement)
        {
            currentIndex++;
            if (currentIndex < 5)
                myInt[currentIndex] = TElement;
            else
            {
                currentIndex = 0;
                myInt[currentIndex] = TElement;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            ClsIEnumerator<T> myClsIEnumerator = new ClsIEnumerator<T>(this);
            return myClsIEnumerator;
        }
        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
    }
    
    }
}
