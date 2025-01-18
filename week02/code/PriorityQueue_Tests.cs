using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue with the following items: (node1, 2), (node2, 2), (node3, 2) and return the queue. This will ensure the items are being added and removed in the correct order when all are tied in priority.
    // Expected Result: node1, node2, node3
    // Defect(s) Found: Dequeue did not remove items from queue. Some operators in the highest priority index if statement were incorrect. Notably, a >= was switched to a > for determining which item should be dequeued when multiple are tied for highest priority.
    public void TestPriorityQueue_Basic()
    {
        var node1 = new PriorityItem("node1", 2);
        var node2 = new PriorityItem("node2", 2);
        var node3 = new PriorityItem("node3", 2);

        PriorityItem[] expectedResult = [node1, node2, node3];

        var priQueue = new PriorityQueue();
        priQueue.Enqueue(node1.Value, node1.Priority);
        priQueue.Enqueue(node2.Value, node2.Priority);
        priQueue.Enqueue(node3.Value, node3.Priority);

        int i = 0;
        while (priQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var node = priQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, node);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Test to see if priority is being followed. Creating a queue with the following items (node1, 2), (node2, 6), (node3, 3) (node4, 5), (node5, 4), (node6, 1)
    // Expected Result: node2, node4, node5, node3, node1, node6
    // Defect(s) Found: None found, previous corrections work.
    public void TestPriorityQueue_Prioritization()
    {
        var node1 = new PriorityItem("node1", 2);
        var node2 = new PriorityItem("node2", 6);
        var node3 = new PriorityItem("node3", 3);
        var node4 = new PriorityItem("node4", 5);
        var node5 = new PriorityItem("node5", 4);
        var node6 = new PriorityItem("node6", 1);

        PriorityItem[] expectedResult = [node2, node4, node5, node3, node1, node6];

        var priQueue = new PriorityQueue();
        priQueue.Enqueue(node1.Value, node1.Priority);
        priQueue.Enqueue(node2.Value, node2.Priority);
        priQueue.Enqueue(node3.Value, node3.Priority);
        priQueue.Enqueue(node4.Value, node4.Priority);
        priQueue.Enqueue(node5.Value, node5.Priority);
        priQueue.Enqueue(node6.Value, node6.Priority);

        int i = 0;
        while (priQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var node = priQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, node);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Test to see if priority is being followed and closest to front is being taken first. Creating a queue with the following items (node1, 2), (node2, 6), (node3, 3) (node4, 2), (node5, 4), (node6, 3)
    // Expected Result: node2, node5, node3, node6, node1, node4
    // Defect(s) Found: No additional problems found.
    public void TestPriorityQueue_EqualPriorities()
    {
        var node1 = new PriorityItem("node1", 2);
        var node2 = new PriorityItem("node2", 6);
        var node3 = new PriorityItem("node3", 3);
        var node4 = new PriorityItem("node4", 2);
        var node5 = new PriorityItem("node5", 4);
        var node6 = new PriorityItem("node6", 3);

        PriorityItem[] expectedResult = [node2, node5, node3, node6, node1, node4];

        var priQueue = new PriorityQueue();
        priQueue.Enqueue(node1.Value, node1.Priority);
        priQueue.Enqueue(node2.Value, node2.Priority);
        priQueue.Enqueue(node3.Value, node3.Priority);
        priQueue.Enqueue(node4.Value, node4.Priority);
        priQueue.Enqueue(node5.Value, node5.Priority);
        priQueue.Enqueue(node6.Value, node6.Priority);

        int i = 0;
        while (priQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var node = priQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, node);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Try to get the next person from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None found.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priQueue = new PriorityQueue();

        try
        {
            priQueue.Dequeue();
            Assert.Fail("The queue is empty.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}