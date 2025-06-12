public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        bool[] visited = new bool[n];
        int provinces = 0;

        void DFS(int city) {
            visited[city] = true;
            for (int neighbor = 0; neighbor < n; neighbor++) {
                if (isConnected[city][neighbor] == 1 && !visited[neighbor]) {
                    DFS(neighbor);
                }
            }
        }

        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                provinces++;
                DFS(i);
            }
        }

        return provinces;
    }
}