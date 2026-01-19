using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue all.
    // Expected Result: Items should be dequeued in order of highest to lowest priority.
    // Defect(s) Found: The original code did not remove the item from the queue after dequeueing, and skipped the last item in the search loop.
    public void TestPriorityQueue_DequeueOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // Highest priority
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Next highest
        Assert.AreEqual("A", priorityQueue.Dequeue()); // Lowest
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same highest priority, then dequeue both.
    // Expected Result: The item that was enqueued last with the highest priority should be dequeued first (since >= is used).
    // Defect(s) Found: The original code did not remove the item from the queue after dequeueing, and skipped the last item in the search loop.
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // Last-in with highest priority
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Should throw InvalidOperationException with the correct message.
    // Defect(s) Found: None in this area.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}