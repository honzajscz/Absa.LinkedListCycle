namespace Absa.LinkedListCycle;

public class Node
{
    public Node(string name)
    {
        Name = name;
    }

    public Node Next { get; set; }

    public string Name { get; set; }

    public Node SetNext(Node next)
    {
        Next = next;
        return next;
    }

    public override string ToString()
    {
        return ToString(0);
    }

    public string ToString(int depth)
    {
        if (Next == null || depth == 10)
            return Name;
        return $"{Name}->{Next.ToString(++depth)}";
    }

    public bool ContainsCycle()
    {
        var lastVisitedIndex = 0;
        var lastVisitedNode = this;

        while (lastVisitedNode != null)
        {
            var currentNode = this;
            for (var i = 0; i < lastVisitedIndex; i++)
            {
                if (currentNode == lastVisitedNode) return true;
                currentNode = currentNode?.Next;
            }

            lastVisitedNode = lastVisitedNode.Next;
            lastVisitedIndex++;
        }

        return false;
    }
}