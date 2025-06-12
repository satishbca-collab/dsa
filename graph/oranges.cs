public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length, cols = grid[0].Length;
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int freshCount = 0, minutes = 0;

        // Initialize queue with rotten oranges and count fresh ones
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 2) queue.Enqueue((i, j));
                else if (grid[i][j] == 1) freshCount++;
            }
        }

        // Directions for adjacent cells (up, down, left, right)
        int[][] directions = new int[][] { new int[] {1, 0}, new int[] {-1, 0}, new int[] {0, 1}, new int[] {0, -1} };

        // BFS traversal
        while (queue.Count > 0 && freshCount > 0) {
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                var (x, y) = queue.Dequeue();
                foreach (var dir in directions) {
                    int newX = x + dir[0], newY = y + dir[1];
                    if (newX >= 0 && newY >= 0 && newX < rows && newY < cols && grid[newX][newY] == 1) {
                        grid[newX][newY] = 2;
                        queue.Enqueue((newX, newY));
                        freshCount--;
                    }
                }
            }
            minutes++;
        }

        return freshCount == 0 ? minutes : -1;
    }
}