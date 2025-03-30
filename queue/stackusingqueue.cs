public class MyStack {
    private Queue<int> queue1;
    private Queue<int> queue2;

    public MyStack() {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }
    
    public void Push(int x) {
        queue1.Enqueue(x);
    }
    
    public int Pop() {
        if (Empty())
            throw new InvalidOperationException("Stack is empty.");

        // Move all elements except the last to queue2
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        // The last element of queue1 is the element to pop
        int poppedElement = queue1.Dequeue();

        // Swap queue1 and queue2
        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;

        return poppedElement;
    }
    
    public int Top() {
        if (Empty())
            throw new InvalidOperationException("Stack is empty.");

        // Move all elements except the last to queue2
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        // The last element of queue1 is the top element
        int topElement = queue1.Peek();

        // Move the top element to queue2
        queue2.Enqueue(queue1.Dequeue());

        // Swap queue1 and queue2
        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;

        return topElement;
    }
    
    public bool Empty() {
        return queue1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */