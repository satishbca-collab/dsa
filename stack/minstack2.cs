public class MinStack {

    private Stack<long> stack;
    private long min;

    public MinStack()
    {
        stack = new Stack<long>();
        min = long.MaxValue;
    }

    // Push an element onto the stack
    public void Push(int x)
    {
        if (stack.Count == 0)
        {
            stack.Push(x);
            min = x;
        }
        else
        {
            if (x < min)
            {
                // Push the encoded value
                stack.Push(2L * x - min);
                min = x; // Update the minimum
            }
            else
            {
                stack.Push(x); // Push normally
            }
        }
    }

    // Pop the top element from the stack
    public void Pop()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        long popped = stack.Pop();

        if (popped < min)
        {
            // Restore the previous minimum
            min = 2L * min - popped;
        }
    }

    // Get the top element of the stack
    public int Top()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        long top = stack.Peek();
        return top < min ? (int)min : (int)top;
    }

    // Get the minimum element in the stack
    public int GetMin()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        return (int)min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */