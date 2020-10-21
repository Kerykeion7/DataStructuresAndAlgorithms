using DataStructures.Lib.Queues;
using System.Collections;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.Queues
{
    public class MyQueueTests
    {
        [Fact]
        public void MyQueue_Equals_OriginalQueue()
        {
            Assert.Equal<object>(
                ArrangeOriginalQueue(), 
                ArrangeMyQueue());
        }

        [Fact]
        public void MyQueueDequeuedObject_Equals_OriginalQueueDequeuedObject()
        {
            Assert.Equal(
                ArrangeOriginalQueue().Dequeue(), 
                ArrangeMyQueue().Dequeue());
        }

        [Fact]
        public void MyQueue_IsEmpty()
        {
            MyQueue myQueue = ArrangeMyQueue();

            myQueue.Clear();

            Assert.Empty(myQueue);
        }

        [Fact]
        public void MyQueue_Contains_T()
        {
            Assert.True(ArrangeMyQueue().Contains("T"));
        }

        [Fact]
        public void MyQueue_DoesNotContain_5()
        {
            Assert.False(ArrangeMyQueue().Contains(5));
        }

        [Fact]
        public void MyQueuePeek_Equals_OriginalQueuePeek()
        {
            Assert.Equal(
                ArrangeOriginalQueue().Peek(), 
                ArrangeMyQueue().Peek());
        }

        private Queue ArrangeOriginalQueue()
        {
            return ActUponQueue(new Queue());
        }

        private MyQueue ArrangeMyQueue()
        {
            return ActUponQueue(new MyQueue());
        }

        private dynamic ActUponQueue(dynamic queue)
        {
            queue.Enqueue(5);
            queue.Enqueue("test");
            queue.Enqueue(2.587);
            queue.Enqueue("T");
            queue.Dequeue();

            return queue;
        }
    }
}
