public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        int[][] dist = new int[m][];
        for (int i = 0; i < m; i++) {
            dist[i] = new int[n];
            Array.Fill(dist[i], int.MaxValue);
        }

        Queue<(int, int)> queue = new Queue<(int, int)>();

        // Initialize queue with all 0 positions and set their distance to 0
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 0) {
                    dist[i][j] = 0;
                    queue.Enqueue((i, j));
                }
            }
        }

        int[][] directions = { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

        // BFS traversal
        while (queue.Count > 0) {
            var (x, y) = queue.Dequeue();

            foreach (var dir in directions) {
                int newX = x + dir[0], newY = y + dir[1];

                if (newX >= 0 && newX < m && newY >= 0 && newY < n) {
                    if (dist[newX][newY] > dist[x][y] + 1) {
                        dist[newX][newY] = dist[x][y] + 1;
                        queue.Enqueue((newX, newY));
                    }
                }
            }
        }

        return dist;
    }
}