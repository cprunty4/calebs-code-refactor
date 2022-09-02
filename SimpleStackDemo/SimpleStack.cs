using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleStackDemo
{
    public class SimpleStack<T>
    {
        readonly T[] _items;
        int _currentIndex = -1;
        public SimpleStack() => _items = new T[10];

        public void Push(T item) => _items[++_currentIndex] = item;

        public T Pop() => _items[_currentIndex--];

        public int Count => _currentIndex + 1;

    }

}