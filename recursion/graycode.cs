public class Solution {
    public IList<int> GrayCode(int n) {
        if(n == 1){
            return new List<int> {0,1};
        }

        IList<int> recursiveResult = GrayCode(n-1);
        IList<int> finalResult = new List<int>();
        // First half: Keep the original Gray Code sequence
        foreach (int code in recursiveResult)
        {
            finalResult.Add(code);
        }

        // Second half: Reflect and prepend the highest bit (1 << (n-1)) in decimal
        int prefix = 1 << (n - 1); // This is 2^(n-1) in decimal
        for (int i = recursiveResult.Count - 1; i >= 0; i--)
        {
            finalResult.Add(prefix + recursiveResult[i]);
        }

        return finalResult;
    }
}