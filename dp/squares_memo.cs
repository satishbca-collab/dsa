public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int, int>();

    public int NumSquares(int n) {
        // Base case: when n is 0, no squares are needed
        if (n == 0) return 0;

        // Check memoized results
        if (memo.ContainsKey(n)) return memo[n];

        
        int minCount = int.MaxValue;
        
        // Try using all possible perfect squares <= n
        for (int i = 1; i * i <= n; i++) {
            minCount = Math.Min(minCount, NumSquares(n - i * i) + 1);
        }
        
        // Store computed result
        memo[n] = minCount;
        return minCount;


    }
}