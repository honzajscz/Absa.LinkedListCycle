namespace Absa.LinkedListCycle;

public class Program
{
    public static void Main()
    {
        var nodeA = new Node("A");
        var nodeB = new Node("B");
        var nodeC = new Node("C");

        Console.WriteLine("1-----------");
        nodeA.SetNext(nodeB).SetNext(nodeC).SetNext(null);
        Console.WriteLine(nodeA);
        var result = nodeA.ContainsCycle();
        Console.WriteLine(result);

        Console.WriteLine("2-----------");
        nodeA.SetNext(nodeB).SetNext(nodeA);
        Console.WriteLine(nodeA);
        result = nodeA.ContainsCycle();
        Console.WriteLine(result);
    }
}