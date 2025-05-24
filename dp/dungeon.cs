public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {

        int m = dungeon.Length, n = dungeon[0].Length;

        int Helper(int i, int j){
            if(i >= m || j >= n){
                return int.MaxValue;
            }

            if(i == m - 1 && j == n - 1){
                return Math.Max(1, 1- dungeon[i][j]);
            }

            int right = Helper(i, j+1);
            int down = Helper(i+1, j);

            int minHealth = Math.Min(right, down) - dungeon[i][j];

            return Math.Max(1, minHealth);
        }

        return Helper(0,0);
    }
}