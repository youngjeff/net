using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApplication18
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
            foreach(T t in this.myInt)
            {
                yield return t;
            }
        }
        //System.Collections.IEnumerator
          
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
