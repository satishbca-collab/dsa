public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        Stack<int> stack = new Stack<int>();

        // Initialize left with -1 (default for no smaller element on the left)
        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }
            left[i] = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(i);
        }

        stack.Clear();

        // Initialize right with n (default for no smaller element on the right)
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }
            right[i] = stack.Count == 0 ? n : stack.Peek();
            stack.Push(i);
        }

        // Calculate the maximum area
        int maxArea = 0;
        for (int i = 0; i < n; i++)
        {
            int width = right[i] - left[i] - 1;
            int area = heights[i] * width;
            maxArea = Math.Max(maxArea, area);
        }

        return maxArea;
    }
}