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

class LinkedList
{
    private Node Head;

    // Insert at the end of the list
    public void Insert(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            return;
        }

        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    // Delete a node by value
    public void Delete(int data)
    {
        if (Head == null)
        {
            Console.WriteLine("The list is empty. Nothing to delete.");
            return;
        }

        if (Head.Data == data)
        {
            Head = Head.Next;
            return;
        }

        Node current = Head;
        while (current.Next != null && current.Next.Data != data)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Value not found in the list.");
        }
        else
        {
            current.Next = current.Next.Next;
        }
    }

    // Display the list
    public void Display()
    {
        if (Head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Insert nodes
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        Console.WriteLine("List after insertion:");
        list.Display();

        // Delete a node
        list.Delete(20);
        Console.WriteLine("List after deletion:");
        list.Display();

        // Try to delete a non-existing node
        list.Delete(40);
        Console.WriteLine("Final list:");
        list.Display();
    }
}
