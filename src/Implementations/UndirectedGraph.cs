// Undirected Unweighted Graph Creation

using System;
using System.Collections.Generic;

public class UndirectedUnweightedGraph
{
   // private int nodeCount;
    private Dictionary<int, List<int>> data;
    public UndirectedUnweightedGraph()
    {
     //   this.nodeCount = 0;
        data = new Dictionary<int, List<int>>();
    }

    public void AddVertex(int node)
    {
        if (!data.ContainsKey(node))
        {
            data.Add(node, new List<int>());
        }
    }

    public void AddEdge(int node1, int node2)
    {
        if (data.ContainsKey(node1))
        {
            if (!data[node1].Contains(node2))
            data[node1].Add(node2);
        }
        // Since its undirected graph, binding should be in both ways
        if (data.ContainsKey(node2))
        {
            if (!data[node2].Contains(node1))
            data[node2].Add(node1);
        }
    }

    public void PrintList()
    {
        foreach(var edge in data)
        {
            Console.Write(edge.Key + "->");
            foreach(int item in edge.Value)
            {
               Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }

}

public class UGraphTest
{
    public void Run()
    {
        UndirectedUnweightedGraph graph = new UndirectedUnweightedGraph();
        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddEdge(1,3);
        graph.AddEdge(1,4);
        graph.AddEdge(2,2);
        graph.AddEdge(4,2);
        graph.PrintList();
    }
}