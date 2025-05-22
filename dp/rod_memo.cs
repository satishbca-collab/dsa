public class Solution {
    private Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();
    public int MinCost(int n, int[] cuts) {
        Array.Sort(cuts);
        return Helper(cuts, 0, n);
    }

    private int Helper(int[] cuts, int l, int r){
        if(l >= r){
            return 0;
        }   

        if (memo.ContainsKey((l, r))) return memo[(l, r)];

        int minCost = int.MaxValue;
        foreach(int cut in cuts){
            int currentSum = 0;
            if(cut > l && cut < r){
                currentSum = (r-l) + Helper(cuts, l, cut) + Helper(cuts, cut, r);
                minCost = Math.Min(minCost, currentSum);
            }
        }
        memo[(l, r)] = (minCost == int.MaxValue) ? 0 : minCost;
        return memo[(l,r)];
    }
}