public class Solution {
    public int UniquePaths(int m, int n) {
        return Helper(m-1,n-1);
    }
    private int Helper(int x, int y){
        if(x == 0 && y == 0){
            return 1;
        }

        if(x < 0 || y < 0){
            return 0;
        }
        int result = Helper(x-1,y) + Helper(x,y-1);
        return result;
    }
}