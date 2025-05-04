public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var result = new List<IList<int>>();
        if (nums1.Length == 0 || nums2.Length == 0 || k == 0) return result;

        var minHeap = new PriorityQueue<(int, int, int), int>();

        // Push initial pairs (nums1[i], nums2[0]) into minHeap
        for (int i = 0; i < nums1.Length && i < k; i++) {
            minHeap.Enqueue((nums1[i], nums2[0], 0), nums1[i] + nums2[0]);
        }

        while (k > 0 && minHeap.Count > 0) {
            var (num1, num2, index2) = minHeap.Dequeue();
            result.Add(new List<int> { num1, num2 });
            k--;

            // Push the next pair (nums1[i], nums2[index2+1]) if within bounds
            if (index2 + 1 < nums2.Length) {
                minHeap.Enqueue((num1, nums2[index2 + 1], index2 + 1), num1 + nums2[index2 + 1]);
            }
        }

        return result;
    }
}