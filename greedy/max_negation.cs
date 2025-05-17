public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length && k > 0; i++) {
            if (nums[i] < 0) {
                nums[i] = -nums[i];
                k--;
            }
        }
        
        int minValue = nums.Min();
        return nums.Sum() - (k % 2) * 2 * minValue;
    }
}