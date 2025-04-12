//https://leetcode.com/problems/longest-substring-without-repeating-characters/description/?ref=bosscoder-academy-2.ghost.io
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLength = 0;
        int left = 0; // The left end of the sliding window
        HashSet<char> window = new HashSet<char>();

        for (int right = 0; right < n; right++)
        {
            // If the character is already in the set, shrink the window from the left
            while (window.Contains(s[right]))
            {
                window.Remove(s[left]);
                left++;
            }

            // Add the current character to the sliding window
            window.Add(s[right]);

            // Update the maximum length of the substring
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}