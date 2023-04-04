public class Queue
{
    private Node front;
    private Node rear;

    public Queue()
    {
        this.front = null;
        this.rear = null;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);

        if (rear == null)
        {
            front = newNode;
            rear = newNode;
            return;
        }

        rear.next = newNode;
        rear = newNode;
    }

    public int Dequeue()
    {
        if (front == null)
        {
            throw new Exception("Queue is empty");
        }

        int data = front.data;
        front = front.next;

        if (front == null)
        {
            rear = null;
        }

        return data;
    }

    public int Peek()
    {
        if (front == null)
        {
            throw new Exception("Queue is empty");
        }

        return front.data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }
}
