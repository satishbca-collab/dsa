public class Solution {
    public int FindPairs(int[] nums, int k) {
        if (k < 0) return 0; // k-diff pairs cannot exist for negative k

        Array.Sort(nums); // Sort the array
        int left = 0, right = 1, count = 0;

        while (left < nums.Length && right < nums.Length) {
            if (left == right || nums[right] - nums[left] < k) {
                right++; // Increase the right pointer if difference is too small
            } else if (nums[right] - nums[left] > k) {
                left++; // Increase the left pointer if difference is too large
            } else { // Found a k-diff pair
                count++;
                left++;
                right++;
                // Skip duplicates
                while (right < nums.Length && nums[right] == nums[right - 1]) {
                    right++;
                }
            }
        }

        return count;
    }
}