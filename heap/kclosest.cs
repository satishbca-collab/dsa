public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> pq = new();
        
        foreach (var p in points) {
            int dist = p[0] * p[0] + p[1] * p[1];
            pq.Enqueue(p, dist);
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++) {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}