public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int LCS(int i, int j){
            if( i == text1.Length || j == text2.Length){
                return 0;
            }

            if(text1[i] == text2[j]){
                return 1 + LCS(i+1, j+1);
            }

            return Math.Max(LCS(i+1, j), LCS(i, j+1));
        }
        return LCS(0, 0);
    }
}