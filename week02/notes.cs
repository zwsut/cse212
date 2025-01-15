// Stacks
// https://byui-cse.github.io/cse212-ww-course/week02/prepare-stacks.html
// Last in, First out
// A stack class is built into C#
// push/pop the back of the stack
// function stacks

// using System;
// using System.Collections.Generic;

// Console.WriteLine("\n======================\nSimple Stack\n======================");

// var stack = new Stack<int>();
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// stack.Pop();
// stack.Pop();
// stack.Push(4);
// stack.Push(5);
// stack.Pop();
// stack.Push(6);
// stack.Push(7);
// stack.Push(8);
// stack.Push(9);
// stack.Pop();
// stack.Pop();
// stack.Push(10);
// stack.Pop();
// stack.Pop();
// stack.Pop();
// stack.Push(11);
// stack.Push(12);
// stack.Pop();
// stack.Pop();
// stack.Pop();
// stack.Push(13);
// stack.Push(14);
// stack.Push(15);
// stack.Push(16);
// stack.Pop();
// stack.Pop();
// stack.Pop();
// stack.Push(17);
// stack.Push(18);
// stack.Pop();
// stack.Push(19);
// stack.Push(20);
// stack.Pop();
// stack.Pop();

// Console.WriteLine("Final contents:");
// Console.WriteLine(String.Join(", ", stack.ToArray()));

// Queues
// https://byui-cse.github.io/cse212-ww-course/week02/prepare-queues.html
// First in, First out
// Can be implemented with a list
// 
// enqueue(value)	Adds "value" to the back of the queue	myQueue.Enqueue(value)	O(1)
// dequeue()	Removes items from the queue	var value = myQueue.Dequeue()	O(1)
// size()	Number of elements in the queue	myQueue.Count	O(1)
// empty()	Returns true if the length of the queue is zero.	if (myQueue.Count == 0)	O(1)

var q = new Queue<char>();
q.Enqueue('A');
char ch = q.Dequeue(); // retrieves the 'A'

// using System;
// using System.Collections.Generic;

// Console.WriteLine("\n======================\nSimple Queue\n======================");

// var queue = new Queue<int>();
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// queue.Dequeue();
// queue.Dequeue();
// queue.Enqueue(4);
// queue.Enqueue(5);
// queue.Dequeue();
// queue.Enqueue(6);
// queue.Enqueue(7);
// queue.Enqueue(8);
// queue.Enqueue(9);
// queue.Dequeue();
// queue.Dequeue();
// queue.Enqueue(10);
// queue.Dequeue();
// queue.Dequeue();
// queue.Dequeue();
// queue.Enqueue(11);
// queue.Enqueue(12);
// queue.Dequeue();
// queue.Dequeue();
// queue.Dequeue();
// queue.Enqueue(13);
// queue.Enqueue(14);
// queue.Enqueue(15);
// queue.Enqueue(16);
// queue.Dequeue();
// queue.Dequeue();
// queue.Dequeue();
// queue.Enqueue(17);
// queue.Enqueue(18);
// queue.Dequeue();
// queue.Enqueue(19);
// queue.Enqueue(20);
// queue.Dequeue();
// queue.Dequeue();

// Console.WriteLine("Final contents:");
// Console.WriteLine(String.Join(", ", queue.ToArray()));

// Code reviews
// Read code "cover to cover"
// "Execute" the code manually
// Analyze the use of data structures
// https://byui-cse.github.io/cse212-ww-course/week02/prepare-reviews.html

// Finding Defects using Tests
// https://byui-cse.github.io/cse212-ww-course/week02/prepare-tests.html

// Instead of printing out the results, test code in C# can use the Trace.Assert function. If the Trace.Assert function fails, then the program will exit and tell you which test (e.g. assert statement) failed. For example:

// Trace.Assert(IsLeapYear(1996), "1996 should have been a leap year"); // true
// Trace.Assert(!IsLeapYear(1900), "1900 should not have been a leap year"); // false
// Trace.Assert(IsLeapYear(2000), "2000 should have been a leap year"); // true
// Trace.Assert(!IsLeapYear(2003), "2003 should not have been a leap year"); // false

// Test 1
// Scenario: Ensure that after adding 3 items to the queue, they
// can be removed in the proper order
// Expected Result: 100, 200, 300
// Console.WriteLine("Test 1");

// var queue = new Queue();
// queue.Enqueue(100);
// queue.Enqueue(200);
// queue.Enqueue(300);

// var result = queue.Dequeue();
// Trace.Assert(result == 100);

// result = queue.Dequeue();
// Trace.Assert(result == 200);

// result = queue.Dequeue();
// Trace.Assert(result == 300);