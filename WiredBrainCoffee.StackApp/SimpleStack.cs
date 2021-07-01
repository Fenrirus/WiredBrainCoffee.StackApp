﻿using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T>
    {
        private readonly T[] _items;
        private int _currentIndex = -1;

        public SimpleStack() => _items = new T[10];

        public int count => _currentIndex + 1;

        public T Pop() => _items[_currentIndex--];

        public void Push(T item)
        {
            _currentIndex++;
            _items[_currentIndex] = item;
        }
    }
}