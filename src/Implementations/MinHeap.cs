// Min Heap Implemenatation
// Time Complexity at its worst is O(nlogn)

using System.Collections.Generic;
using System;

public class MinHeap
{
    public List<int> data;

    public MinHeap()
    {
        this.data = new List<int>();
    }

    public MinHeap(int count)
    {
        this.data = new List<int>(count);
    }

    private int GetParent(int childNodeIndex)
    {
        return (childNodeIndex <= 0) ? -1 : (childNodeIndex - 1) / 2;
    }

    private int GetLeftChildNodeIndex(int parentNodeIndex)
    {
        return (parentNodeIndex < 0) ? -1 : (parentNodeIndex * 2) + 1;
    }

    private int GetRightChildNodeIndex(int parentNodeIndex)
    {
        return (parentNodeIndex < 0) ? -1 : (parentNodeIndex * 2) + 2;
    }

    public int PopMin()
    {
        if (data.Count == 0) throw new System.Exception("No Elements left in the list");
        int result = data[0];
        data[0] = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        BubbleDown(0);
        return result;
    }

    private void BubbleDown(int itemIndex)
    {
        if (itemIndex > data.Count - 1) return;

        int leftNodeIndex = GetLeftChildNodeIndex(itemIndex);
        int rightNodeIndex = GetRightChildNodeIndex(itemIndex);

        if (leftNodeIndex > data.Count - 1 || rightNodeIndex > data.Count - 1) return;

        if (data[itemIndex] > data[leftNodeIndex])
        {
            Swap(itemIndex, leftNodeIndex);
            BubbleDown(leftNodeIndex);
        }
        if (data[itemIndex] > data[rightNodeIndex])
        {
            Swap(itemIndex, rightNodeIndex);
            BubbleDown(rightNodeIndex);
        }
    }

    public void Add(int item)
    {
        data.Add(item);
        BubbleUp(data.Count - 1);
    }

    private void BubbleUp(int index)
    {
        if (index == 0) return;
        int parentIndex = GetParent(index);
        if (data[parentIndex] > data[index])
        {
            Swap(parentIndex, index);
            BubbleUp(parentIndex);
        }
    }

    private void Swap(int nodeA, int nodeB)
    {
        int temp = data[nodeA];
        data[nodeA] = data[nodeB];
        data[nodeB] = temp;
    }

}

public class MinHeapTest
{
    public void Run()
    {
        MinHeap heap = new MinHeap();
        heap.Add(22);
        heap.Add(20);
        heap.Add(12);
        heap.Add(5);
        heap.Add(30);
        Console.WriteLine(heap.PopMin());
        heap.Add(7);
        heap.Add(8);
        Console.WriteLine(heap.PopMin());
    }
}