public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] arr = new int[m][];
        for(int i = 0; i < m; i++){
            arr[i] = new int[n];
            for(int j = 0; j < n; j++){
                arr[i][j] = -1;
            }
        }
        Helper(m-1,n-1,arr);
        return arr[m-1][n-1];
    }

    private int Helper(int x, int y, int[][] arr){
        
        if(x == 0 && y == 0){
            arr[x][y] = 1;
            return 1;
        }

        if(x < 0 || y < 0){
            return 0;
        }
        if(arr[x][y] != -1){
            return arr[x][y];
        }
        int result = Helper(x-1,y, arr) + Helper(x,y-1, arr);
        arr[x][y] = result;
        return result;
    }
}