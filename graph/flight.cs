public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        var graph = new Dictionary<int, List<(int, int)>>();
        foreach (var flight in flights) {
            if (!graph.ContainsKey(flight[0])) graph[flight[0]] = new List<(int, int)>();
            graph[flight[0]].Add((flight[1], flight[2]));
        }

        var pq = new PriorityQueue<(int cost, int city, int stops), int>();
        pq.Enqueue((0, src, 0), 0);

        var visited = new Dictionary<(int, int), int>();

        while (pq.Count > 0) {
            var (cost, city, stops) = pq.Dequeue();
            if (city == dst) return cost;
            if (stops > k || visited.ContainsKey((city, stops)) && visited[(city, stops)] <= cost) continue;

            visited[(city, stops)] = cost;

            if (graph.ContainsKey(city)) {
                foreach (var (nextCity, price) in graph[city]) {
                    pq.Enqueue((cost + price, nextCity, stops + 1), cost + price);
                }
            }
        }

        return -1;
    }
}