public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        bool[][] visited = new bool[m][];
        for(int i = 0; i < m; i++){
            visited[i] = new bool[n];
        }

        int count = 0;
        for(int i = 0; i < m; i++ ){
            for(int j = 0; j < n; j++){
                if(!visited[i][j] && grid[i][j] == '1'){
                    Helper(grid, visited, i, j);
                    count++;
                }
                
            }
        }
        return count;
    }

    private void Helper(char[][] grid, bool[][] visited, int i, int j){
        int m = grid.Length, n = grid[0].Length;
        
        if( i >= m || j >= n || i < 0 || j < 0 || visited[i][j] || grid[i][j] == '0') return;

        visited[i][j] = true;

        Helper(grid, visited, i+1, j);
        Helper(grid, visited, i, j+1);
        Helper(grid, visited, i-1, j);
        Helper(grid, visited, i, j-1);
        
    }
}