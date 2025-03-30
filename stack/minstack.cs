public class MinStack {

    private Stack<int> stack; // Single stack to store all elements and minimums
    private int min; // Current minimum value

    public MinStack()
    {
        stack = new Stack<int>();
        min = int.MaxValue;
    }

    // Push an element onto the stack
    public void Push(int x)
    {
        if (x <= min)
        {
            // Store the current minimum in the stack before updating
            stack.Push(min);
            min = x;
        }
        stack.Push(x); // Push the actual value
    }

    // Pop the top element from the stack
    public void Pop()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        int popped = stack.Pop();
        if (popped == min)
        {
            // Restore the previous minimum
            min = stack.Pop();
        }
    }

    // Get the top element of the stack
    public int Top()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        return stack.Peek();
    }

    // Get the minimum element in the stack
    public int GetMin()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        return min;
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