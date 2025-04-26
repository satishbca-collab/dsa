using System;
using System.Collections.Generic;

class MinHeap
{
    private List<int> heap = new List<int>();

    private void Swap(int i, int j)
    {
        (heap[i], heap[j]) = (heap[j], heap[i]);
    }

    public void Insert(int val)
    {
        heap.Add(val);
        int current = heap.Count - 1;

        while (current > 0)
        {
            int parent = (current - 1) / 2;
            if (heap[parent] > heap[current])
            {
                Swap(parent, current);
                current = parent;
            }
            else
                break;
        }
    }

    public int ExtractMin()
    {
        if (heap.Count == 0) throw new InvalidOperationException("Heap is empty!");

        int min = heap[0];
        heap[0] = heap[^1];
        heap.RemoveAt(heap.Count - 1);

        int current = 0;
        while (true)
        {
            int left = 2 * current + 1, right = 2 * current + 2, smallest = current;

            if (left < heap.Count && heap[left] < heap[smallest]) smallest = left;
            if (right < heap.Count && heap[right] < heap[smallest]) smallest = right;

            if (smallest != current)
            {
                Swap(current, smallest);
                current = smallest;
            }
            else
                break;
        }

        return min;
    }

    public void PrintHeap()
    {
        Console.WriteLine("Heap Elements: " + string.Join(", ", heap));
    }
}

class Program
{
    static void Main()
    {
        MinHeap minHeap = new MinHeap();
        minHeap.Insert(10);
        minHeap.Insert(20);
        minHeap.Insert(5);
        minHeap.Insert(15);

        minHeap.PrintHeap();
        Console.WriteLine("Extract Min: " + minHeap.ExtractMin());
        minHeap.PrintHeap();
    }
}
