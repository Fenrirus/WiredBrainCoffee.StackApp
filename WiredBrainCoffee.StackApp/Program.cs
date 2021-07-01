using System;

namespace WiredBrainCoffee.StackApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StackDoubles();
            StackString();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            var sum = 0.0d;

            while (stack.count > 0)
            {
                var item = (double)stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum {sum}");
        }

        private static void StackString()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Robert");
            stack.Push("Marta");

            while (stack.count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}