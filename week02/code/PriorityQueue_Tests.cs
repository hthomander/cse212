using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a low-priority item, two equal highest-priority items, and a medium-priority item.
    // Expected Result: Dequeue returns both highest-priority items first in enqueue order, then the medium and low items.
    // Defect(s) Found: The scan skipped the last item, selected the later item when priorities tied, and returned items without removing them.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("first high", 5);
        priorityQueue.Enqueue("second high", 5);
        priorityQueue.Enqueue("medium", 3);

        Assert.AreEqual("first high", priorityQueue.Dequeue());
        Assert.AreEqual("second high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue.
    // Expected Result: InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: None. The empty queue correctly throws InvalidOperationException with the required message.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    // Add more test cases as needed below.
}