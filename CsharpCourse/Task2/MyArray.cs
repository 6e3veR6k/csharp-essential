using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class MyArray<T>
    {
        private T[] _items;
        private int _size;

        private int _defaultCapacity = 4;

        public MyArray()
        {
            _items = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Length) Console.WriteLine("Index out of range");
                return _items[index];
            }

            set
            {
                if (index >= 0 && index < _items.Length)
                { 
                    _items[index] = value; 
                }
                else
                { 
                    Console.WriteLine("Index out of range"); 
                }
            }
        }

        public void Add(T element)
        {
            if (_items.Length == _size) ExtendArray();

            _size++;

            _items[_size] = element;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= _items.Length) throw new IndexOutOfRangeException();

            Array.Copy(_items, index + 1, _items, index, _items.Length - index);
        }

        private void ExtendArray()
        {
            T[] newItems = new T[_defaultCapacity *= 4];

            Array.Copy(_items, 0, newItems, 0, _items.Length);
            _items = newItems;
        }

        public int GetLength() => _size;
    }
}
