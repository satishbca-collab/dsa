public class Solution {
    public int NumSquares(int n) {
        // Base case: when n is 0, no squares are needed
        if (n == 0) return 0;
        
        int minCount = int.MaxValue;
        
        // Try using all possible perfect squares <= n
        for (int i = 1; i * i <= n; i++) {
            minCount = Math.Min(minCount, NumSquares(n - i * i) + 1);
        }
        
        return minCount;

    }
}