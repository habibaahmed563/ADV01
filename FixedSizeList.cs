using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class FixedSizeList<T>
    {
        public T[] items;
        public int count;

        public int Capacity { get; }
        public int Count => count; 

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException("Capacity must me more than 0");

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }


        public void Add(T item)
        {
            if (count >= Capacity)
                throw new InvalidOperationException("List is full , sorry can not add more elements");

            items[count++] = item;
        }

        public T Get(int index)
        {
            if(index<0||index>=count)
                throw new IndexOutOfRangeException("invalid index");
            return items[index];
        }
    }
}
