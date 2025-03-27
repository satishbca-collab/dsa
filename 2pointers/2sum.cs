public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create a temporary array to store the original numbers and their indices
        int[][] numWithIndex = new int[nums.Length][];
        for (int i = 0; i < nums.Length; i++) {
            numWithIndex[i] = new int[] { nums[i], i };
        }

        // Sort the temporary array based on the numbers
        Array.Sort(numWithIndex, (a, b) => a[0].CompareTo(b[0]));

        int left = 0;
        int right = numWithIndex.Length - 1;

        while (left < right) {
            int sum = numWithIndex[left][0] + numWithIndex[right][0];

            if (sum == target) {
                return new int[] { numWithIndex[left][1], numWithIndex[right][1] };
            } else if (sum < target) {
                left++; // Move left pointer forward to increase sum
            } else {
                right--; // Move right pointer backward to decrease sum
            }
        }

        throw new Exception("No two sum solution");
    }
}