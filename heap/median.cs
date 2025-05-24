public class MedianFinder {

    private PriorityQueue<int, int> minHeap; // Stores larger half (min-heap)
    private PriorityQueue<int, int> maxHeap; // Stores smaller half (max-heap, negated values)

    public MedianFinder() {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    }

    public void AddNum(int num) {
        maxHeap.Enqueue(num, num);

        // Move the largest element from maxHeap to minHeap
        if (maxHeap.Count > 0)
        {
            int maxFromSmaller = maxHeap.Dequeue();
            minHeap.Enqueue(maxFromSmaller, maxFromSmaller);
        }
        
        // Balance the heaps - maxHeap should have at most 1 more element than minHeap
        if (minHeap.Count > maxHeap.Count + 1)
        {
            int minFromLarger = minHeap.Dequeue();
            maxHeap.Enqueue(minFromLarger, minFromLarger);
        }
    }

    public double FindMedian() {

        if (maxHeap.Count == minHeap.Count) {
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
        }
        return minHeap.Peek();
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */