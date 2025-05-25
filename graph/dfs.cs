using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private Dictionary<int, List<int>> adj;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new Dictionary<int, List<int>>();

        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void InsertEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u); // For undirected graph
    }

    private void DFSHelper(int u, HashSet<int> visited)
    {
        visited.Add(u);
        Console.WriteLine(u);

        foreach (int v in adj[u])
        {
            if (!visited.Contains(v))
            {
                DFSHelper(v, visited);
            }
        }
    }

    public void DFS(int startVertex)
    {
        HashSet<int> visited = new HashSet<int>();
        DFSHelper(startVertex, visited);
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(7);

        g.InsertEdge(0, 1);
        g.InsertEdge(0, 3);
        g.InsertEdge(1, 4);
        g.InsertEdge(1, 2);
        g.InsertEdge(2, 3);
        g.InsertEdge(4, 5);
        g.InsertEdge(4, 6);
        g.InsertEdge(5, 6);

        g.DFS(0);
    }
}