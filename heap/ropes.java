class Solution {
    public static int minCost(int[] ropes) {
        // code here
        PriorityQueue<Integer> minHeap = new PriorityQueue<>();

        // Insert all ropes into the min heap
        for (int rope : ropes) {
            minHeap.add(rope);
        }

        int totalCost = 0;

        // Combine ropes until only one remains
        while (minHeap.size() > 1) {
            int first = minHeap.poll();  // Remove smallest rope
            int second = minHeap.poll(); // Remove second smallest rope
            int sum = first + second;
            totalCost += sum;

            // Insert the combined rope back into the heap
            minHeap.add(sum);
        }

        return totalCost;
    }
}