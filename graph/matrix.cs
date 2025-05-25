using System;

class Graph
{
    private bool[,] adjMatrix;
    private int numVertices;

    public Graph(int numVertices)
    {
        this.numVertices = numVertices;
        adjMatrix = new bool[numVertices, numVertices];
    }

    public void AddEdge(int i, int j)
    {
        adjMatrix[i, j] = true;
        adjMatrix[j, i] = true;
    }

    public void RemoveEdge(int i, int j)
    {
        adjMatrix[i, j] = false;
        adjMatrix[j, i] = false;
    }

    public void PrintGraph()
    {
        for (int i = 0; i < numVertices; i++)
        {
            Console.Write(i + " : ");
            for (int j = 0; j < numVertices; j++)
            {
                Console.Write(adjMatrix[i, j] ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(4);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);

        g.PrintGraph();
    }
}