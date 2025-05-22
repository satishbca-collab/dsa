public class Solution {
    public int NumDecodings(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        Dictionary<int, int> memo = new Dictionary<int, int>();
        return Helper(s, 0, memo);
    }

    private int Helper(string s, int l, Dictionary<int, int> memo){
        if(l == s.Length){
            return 1;
        }
        if (s[l] == '0') return 0; // '0' alone is invalid.

        // If we've already computed this subproblem, return cached result
        if (memo.ContainsKey(l)) return memo[l];

        int sum = Helper(s,l+1, memo);

        if(l+1 < s.Length){
            int twoDigit = int.Parse(s.Substring(l, 2));
            if(twoDigit >= 10 && twoDigit <= 26){
                sum+= Helper(s, l+2, memo);
            }
        }
        memo[l] = sum;
        return sum;
    }
}