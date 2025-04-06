using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class Stack
{
    private Node Top;

    public Stack()
    {
        Top = null;
    }

    // Push an element onto the stack
    public void Push(int data)
    {
        Node newNode = new Node(data);
        if (Top == null)
        {
            Top = newNode;
        }
        else
        {
            newNode.Next = Top;
            Top = newNode;
        }
    }

    // Pop an element from the stack
    public int Pop()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack underflow! The stack is empty.");
            return -1;
        }

        int poppedData = Top.Data;
        Top = Top.Next;
        return poppedData;
    }

    // Peek at the top element of the stack
    public int Peek()
    {
        if (Top == null)
        {
            Console.WriteLine("The stack is empty.");
            return -1;
        }

        return Top.Data;
    }

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return Top == null;
    }

    // Display the elements in the stack
    public void Display()
    {
        if (Top == null)
        {
            Console.WriteLine("The stack is empty.");
            return;
        }

        Node current = Top;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        // Push elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Stack after pushing elements:");
        stack.Display();

        // Peek at the top element
        Console.WriteLine("Top element is: " + stack.Peek());

        // Pop an element from the stack
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Stack after popping an element:");
        stack.Display();

        // Check if the stack is empty
        Console.WriteLine("Is the stack empty? " + stack.IsEmpty());
    }
}
