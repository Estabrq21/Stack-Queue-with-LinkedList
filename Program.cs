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

        Console.WriteLine(stack.Pop()); 
        Console.WriteLine(stack.Pop()); 
        Console.WriteLine(stack.Peek()); 

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Peek()); 
    }
}
