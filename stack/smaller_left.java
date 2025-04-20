class Solution {
    public int[] leftSmaller(int[] arr) {
        // code here
        int n = arr.length;
        int[] result = new int[n];
        Stack<Integer> st = new Stack<>();
        
        for (int i = 0; i < n; i++) {
            // Pop elements from stack until we find a smaller element
            while (!st.isEmpty() && st.peek() >= arr[i]) {
                st.pop();
            }
            // If stack is empty, no smaller element exists
            result[i] = st.isEmpty() ? -1 : st.peek();
            
            // Push current element onto the stack
            st.push(arr[i]);
        }
        
        return result;
    }
}