using System;

public class Program
{
    public static void Main()
    {
        Stack stack = new Stack();
        Queue queue = new Queue();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop()); // Outputs 3
        Console.WriteLine(stack.Pop()); // Outputs 2
        Console.WriteLine(stack.Peek()); // Outputs 1

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); // Outputs 1
        Console.WriteLine(queue.Dequeue()); // Outputs 2
        Console.WriteLine(queue.Peek()); // Outputs 3
    }
}
