using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism1
{
    class List1<T>
    {
        private T[] array1;

        public List1(int length)
        {
            array1 = new T[length];
        }

        public T GetElement(int index)
        {
            return array1[index];
        }

        public void AddElement(T element, int position)
        {
            array1[position] = element;
        }
    }
}
