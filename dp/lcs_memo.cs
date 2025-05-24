public class Solution {
    private int[,] memo;
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length, n = text2.Length;
        memo = new int[m,n];

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                memo[i,j] = -1;
            }
        }
        int LCS(int i, int j){
            if( i == text1.Length || j == text2.Length){
                return 0;
            }

            if(memo[i,j] != -1){
                return memo[i,j];
            }

            if(text1[i] == text2[j]){
                memo[i,j] = 1 + LCS(i+1, j+1);
            }
            else {
                memo[i,j] = Math.Max(LCS(i+1, j), LCS(i, j+1));
            }
            return memo[i,j];
        }
        return LCS(0, 0);
    }
}