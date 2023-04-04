using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stack
{
    private Node top;

    public Stack()
    {
        this.top = null;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
        {
            throw new Exception("Stack is empty");
        }

        int data = top.data;
        top = top.next;
        return data;
    }

    public int Peek()
    {
        if (top == null)
        {
            throw new Exception("Stack is empty");
        }

        return top.data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}
