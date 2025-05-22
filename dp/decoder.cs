public class Solution {
    public int NumDecodings(string s) {
        return Helper(s, 0);
    }

    private int Helper(string s, int l){
        if(l == s.Length){
            return 1;
        }
        if (s[l] == '0') return 0; // '0' alone is invalid.

        int sum = Helper(s,l+1);

        if(l+1 < s.Length){
            int twoDigit = int.Parse(s.Substring(l, 2));
            if(twoDigit >= 10 && twoDigit <= 26){
                sum+= Helper(s, l+2);
            }
        }

        return sum;
    }
}