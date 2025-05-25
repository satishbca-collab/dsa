using System;
using System.Collections.Generic;

class Graph
{
    private List<int>[] adj;
    private int V;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int s, int d)
    {
        adj[s].Add(d);
        adj[d].Add(s); // For undirected graph
    }

    public void PrintGraph()
    {
        for (int i = 0; i < V; i++)
        {
            Console.Write($"\nVertex {i}:");
            foreach (var x in adj[i])
            {
                Console.Write($" -> {x}");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int V = 5;
        Graph graph = new Graph(V);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 2);

        graph.PrintGraph();
    }
}