public class Solution {
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> result = new List<IList<string>>();
        PartitionHelper(s, 0, new List<string>(), result);
        return result;
    }

    private void PartitionHelper(string s, int start, List<string> path, IList<IList<string>> result) {
        if (start == s.Length) {
            result.Add(new List<string>(path));
            return;
        }
        for (int end = start; end < s.Length; end++) {
            if (IsPalindrome(s, start, end)) {
                path.Add(s.Substring(start, end - start + 1));
                PartitionHelper(s, end + 1, path, result);
                path.RemoveAt(path.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}