using System;

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

//Implementation for Queue
public class Queue
{
    private Node head;
    public void Enqueue(int data)
    {
        Node newnode = new Node(data);
        if (head == null)
        {
            head = newnode;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newnode;
        }
    }
    public void Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("queue is empty");
            return;
        }
        head = head.Next;
    }

    public void Peek()
    {
        if (head == null)
        {
            Console.WriteLine("queue is empty");
            return;
        }
        Console.WriteLine("the front element is " + head.Data);
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

//Implementation for stack
public class Stack
{
    private Node head;
    public void Push(int data)
    {
        Node newnode = new Node(data);
        if (head == null)
        {
            head = newnode;
        }
        else
        {
            newnode.Next = head;
            head = newnode;
        }
    }
    public void Pop()
    {
        if (head == null)
        {
            Console.WriteLine("stack is empty");
            return;
        }
        head = head.Next;
    }

    public void Peek()
    {
        if (head == null)
        {
            Console.WriteLine("stack is empty");
            return;
        }
        Console.WriteLine("the top element is " + head.Data);
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("The Queue:");
        Queue queue = new Queue();
        //Entering elements in the Queue
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Display();

        //Removing element as per FIFO
        queue.Dequeue();
        Console.WriteLine("After deleting a element in the Queue:");
        queue.Display();
        queue.Peek();



        Console.WriteLine("\nThe Stact:");
        Stack stack = new Stack();
        //Entering elements in the Stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Display();

        //Removing Elements as per LIFO
        stack.Pop();
        Console.WriteLine("After deleting a element in the Stack:");
        stack.Display();
        stack.Peek();
    }
}