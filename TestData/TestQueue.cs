using datastructres;
using NUnit.Framework;
using System;

namespace TestData
{
    [TestFixture]
   public  class TestQueue
    {
        [Test]
        public void test_enqueue_one()
        {
            var queue = new QueueList(3);
            queue.Enqueue(1);

            Assert.AreEqual(1,queue.Count);
        }

        [Test]
        public void test_enqueue_two()
        {
            var queue = new QueueList(3);
            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.AreEqual(2, queue.Count);
        }

        [Test]
        public void test_dequeue()
        {
            var queue = new QueueList(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            var value= queue.Dequeue();
            Assert.AreEqual(1, value);

          
        }

        [Test]
        public void test_dequeue_error_empty_queue()
        {
            var queue = new QueueList(3);

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());

        }


        [Test]
        public void test_dequeue_error_max_queue()
        {
            var queue = new QueueList(1);
            queue.Enqueue(1);

            Assert.Throws<InvalidOperationException>(() =>queue.Enqueue(2));

        }
    }
}
