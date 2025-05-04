class Solution {
    public void nearlySorted(int[] arr, int k) {
        // code here
        PriorityQueue<Integer> minHeap = new PriorityQueue<>();
        
        // Add first k+1 elements to the heap
        int i;
        for (i = 0; i <= k; i++) {
            minHeap.add(arr[i]);
        }
        
        int index = 0;
        // Process remaining elements
        while (i < arr.length) {
            arr[index++] = minHeap.poll();  // Extract min and place it at the correct position
            minHeap.add(arr[i++]);          // Add next element from the array
        }
        
        // Extract remaining elements from the heap
        while (!minHeap.isEmpty()) {
            arr[index++] = minHeap.poll();
        }
    }
}