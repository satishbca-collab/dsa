public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
        prefixSumCount[0] = 1; // Base case: Prefix sum of zero occurs once

        int count = 0;
        int currentSum = 0;

        foreach (int num in nums) {
            currentSum += num;

            // Check if there exists a prefix sum that makes the current sum - k
            if (prefixSumCount.ContainsKey(currentSum - k)) {
                count += prefixSumCount[currentSum - k];
            }

            // Add the current sum to the hashmap
            if (prefixSumCount.ContainsKey(currentSum)) {
                prefixSumCount[currentSum]++;
            } else {
                prefixSumCount[currentSum] = 1;
            }
        }

        return count;
    }
}