using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public int Count { get { return list.Count; } }

        public T Add(T element) 
        { 
            list.Add(element);
            return element;
        }

        public T Remove() 
        {
            T last = list.Last();
            list.Remove(last);
            return last;
        }
    }
}
