using System;
using System.Collections.Generic;

class Graph
{
    private int numberOfVertices;
    private List<int>[] adjacencyList;

    public Graph(int vertices)
    {
        numberOfVertices = vertices;
        adjacencyList = new List<int>[vertices];

        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int from, int to)
    {
        adjacencyList[from].Add(to);
        adjacencyList[to].Add(from); // For undirected graph
    }

    public void BFSTraversal(int startingVertex)
    {
        bool[] visited = new bool[numberOfVertices];
        Queue<int> queue = new Queue<int>();

        visited[startingVertex] = true;
        queue.Enqueue(startingVertex);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            Console.Write(vertex + " ");

            foreach (int neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(7);

        graph.AddEdge(0, 3);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 3);
        graph.AddEdge(2, 5);
        graph.AddEdge(3, 6);

        graph.BFSTraversal(1);
    }
}