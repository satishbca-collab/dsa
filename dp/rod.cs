public class Solution {
    public int MinCost(int n, int[] cuts) {
        Array.Sort(cuts);
        return Helper(cuts, 0, n);
    }

    private int Helper(int[] cuts, int l, int r){
        if(l >= r){
            return 0;
        }   
        int minSum = int.MaxValue;
        foreach(int cut in cuts){
            int currentSum = 0;
            if(cut > l && cut < r){
                currentSum = (r-l) + Helper(cuts, l, cut) + Helper(cuts, cut, r);
                minSum = Math.Min(minSum, currentSum);
            }
        }
        return minSum == int.MaxValue ? 0: minSum;
    }
}