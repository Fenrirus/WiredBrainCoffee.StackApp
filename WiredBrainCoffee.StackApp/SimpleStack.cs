using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private readonly double[] _items;
        private int _currentIndex = -1;

        public SimpleStack() => _items = new double[10];

        public int count => _currentIndex + 1;

        public double Pop() => _items[_currentIndex--];

        public void Push(double item)
        {
            _currentIndex++;
            _items[_currentIndex] = item;
        }
    }
}