public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        HashSet<int> visited = new HashSet<int>();

        // Build adjacency list
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == '1') {
                    int node = i * n + j;
                    graph[node] = new List<int>();

                    // Connect to adjacent '1' cells
                    if (i > 0 && grid[i - 1][j] == '1') graph[node].Add((i - 1) * n + j); // Up
                    if (i < m - 1 && grid[i + 1][j] == '1') graph[node].Add((i + 1) * n + j); // Down
                    if (j > 0 && grid[i][j - 1] == '1') graph[node].Add(i * n + (j - 1)); // Left
                    if (j < n - 1 && grid[i][j + 1] == '1') graph[node].Add(i * n + (j + 1)); // Right
                }
            }
        }

        // Count connected components using DFS
        int islandCount = 0;
        foreach (var node in graph.Keys) {
            if (!visited.Contains(node)) {
                DFS(graph, visited, node);
                islandCount++;
            }
        }

        return islandCount;
    }

    private void DFS(Dictionary<int, List<int>> graph, HashSet<int> visited, int node) {
        if (visited.Contains(node)) return;
        visited.Add(node);
        foreach (var neighbor in graph[node]) {
            if (!visited.Contains(neighbor)) {
                DFS(graph, visited, neighbor);
            }
        }
    }
}