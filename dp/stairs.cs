public class Solution {
    public int ClimbStairs(int n) {
        int[] dp = new int[n+1];
        dp[0] = 1; dp[1] = 1;
        return Helper(n, dp);
    }

    private int Helper(int n, int[] dp) {
        if (n <= 1) return 1;
        if (dp[n] != 0) return dp[n];
        return dp[n]=Helper(n - 1, dp) + Helper(n - 2, dp); 
    }
}