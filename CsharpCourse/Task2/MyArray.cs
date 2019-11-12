using System;
using System.Collections.Generic;
using System.Text;

namespace Geneics2
{
    public class MyArray<T>
    {
        private T[] items;


        private int count;
        private int defaultCapacity = 4;

        public int ItemsCount
        {
            get => count;
        }

        private T[] emptyArray = new T[0];

        public MyArray()
        {
            items = emptyArray;
        }

        public MyArray(params T[] items)
        {
            this.items = items;
            count = this.items.Length;
        }

        private void ExtendArray()
        {
            T[] temp;
            if (items.Length == 0)
            {
                items = new T[defaultCapacity];
            }
            else
            {
                temp = new T[count * defaultCapacity];
                Array.Copy(items, 0, temp, 0, items.Length - 1);
                items = temp;
            }
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                ExtendArray();
            }

            this.items[count++] = item;
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < items.Length)
            {
                count--;
                Array.Copy(items, index + 1, items, index, count - index);
            }

        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Length)
                    return items[index];
                else
                    throw new IndexOutOfRangeException();
            }

            set
            {
                if (index >= 0 && index < items.Length)
                    items[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
