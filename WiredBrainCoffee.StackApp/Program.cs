using System;

namespace WiredBrainCoffee.StackApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stack = new SimpleStack();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            var sum = 0.0d;

            while (stack.count > 0)
            {
                var item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum {sum}");
            Console.ReadLine();
        }
    }
}