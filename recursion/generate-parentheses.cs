public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        Helper(result, string.Empty, 0, 0, n);
        return result;
    }

    private void Helper(IList<string> result, string current, int openCount, int closedCount, int n){
        if(current.Length == 2*n){
            result.Add(current);
            return;
        }

        if(openCount < n){
            Helper(result, current + "(", openCount+1, closedCount, n);
        }

        if(closedCount < openCount){
            Helper(result, current + ")", openCount, closedCount+1, n);
        }
    }
}