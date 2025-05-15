public class Solution {
    public int Rob(int[] nums) {
        int[] dp = new int[nums.Length];
        for (int i = 0; i < dp.Length; i++) {
            dp[i] = -1;
        }
        return Helper(nums, 0, dp);
    }

    private int Helper(int[] nums, int i, int[] dp){
        if(i >= nums.Length){
            return 0;
        }

        if(dp[i] != -1) return dp[i];
        dp[i] = Math.Max(nums[i] + Helper(nums, i+2, dp), Helper(nums, i+1, dp));
        return dp[i];
    }
}