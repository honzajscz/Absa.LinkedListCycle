using NUnit.Framework;

namespace Absa.LinkedListCycle.Tests;

public class LinkedListTests
{
    [Test]
    public void NoCycle()
    {
        // arrange 
        var nodeA = new Node("A");
        var nodeB = new Node("B");
        var nodeC = new Node("C");

        nodeA.SetNext(nodeB).SetNext(nodeC).SetNext(null);

        // act
        var result = nodeA.ContainsCycle();

        // assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Cycle_A_B_A()
    {
        // arrange 
        var nodeA = new Node("A");
        var nodeB = new Node("B");

        nodeA.SetNext(nodeB).SetNext(nodeA);

        // act
        var result = nodeA.ContainsCycle();

        // assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Cycle_A_B_B()
    {
        // arrange 
        var nodeA = new Node("A");
        var nodeB = new Node("B");

        nodeA.SetNext(nodeB).SetNext(nodeB);

        // act
        var result = nodeA.ContainsCycle();

        // assert
        Assert.IsTrue(result);
    }

    [Test]
    public void NoCycle_Single_Node()
    {
        // arrange 
        var nodeA = new Node("A");

        // act
        var result = nodeA.ContainsCycle();

        // assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Cycle_Single_Node()
    {
        // arrange 
        var nodeA = new Node("A");
        nodeA.SetNext(nodeA);

        // act
        var result = nodeA.ContainsCycle();

        // assert
        Assert.IsTrue(result);
    }
}