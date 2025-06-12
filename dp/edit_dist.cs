public class Solution {
    public int MinDistance(string word1, string word2) {
        int[,] memo = new int[word1.Length, word2.Length]; 
        int m = word1.Length - 1, n = word2.Length - 1;
        return Helper(word1, word2, m, n, memo);
    }

    private int Helper(string word1, string word2, int i, int j, int[,] memo){
        // Base Cases
        if (i < 0) return j + 1;
        if (j < 0) return i + 1;

        // Check Memoized Result
        if (memo[i, j] != 0) return memo[i, j];

        if(word1[i] == word2[j]){
            memo[i, j] = Helper(word1, word2, i-1, j-1, memo);
        }
        else memo[i, j] =  1 + Math.Min(Math.Min(Helper(word1, word2, i-1, j-1, memo), Helper(word1, word2, i-1, j, memo)), Helper(word1, word2, i, j-1, memo));

        return memo[i,j];
    }
}