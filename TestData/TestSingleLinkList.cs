using datastructres;
using NUnit.Framework;

namespace TestData
{
    [TestFixture]
    public class TestSingleLinkList
    {
        SingleLinkedList<int> test_list;

        [SetUp]
        public void SomeSetup()
        {
            SingleLinkedList<int> test_list = new SingleLinkedList<int>();
        }

        [Test]
        public void test_addNode()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.AddNode(1);
            test.AddNode(3);

            Assert.AreEqual(test.headNode.next.data,3);
        }


        [Test]
        public void test_addNode_count()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.AddNode(1);
            test.AddNode(3);
            test.AddNode(4);
            test.AddNode(5);

            Assert.AreEqual(test.Lenght, 4);
        }
        [Test]
        public void test_addInfront()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();

            test.InsertFront(1);
            Assert.AreEqual(test.headNode.next, null);
        }

        [Test]
        public void test_last_one_data_infront()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.AddNode(1);
            test.AddNode(3);
            test.AddNode(4);
            test.InsertFront(5);

            Assert.AreEqual(test.headNode.data, 5 );
        }

        [Test]
        public void test_next_is_null()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertFront(1);
            test.InsertFront(2);

            Assert.AreEqual(test.headNode.next.next,null);
        }

        [Test]
        public void test_itearation_next()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertFront(1);
            test.InsertFront(2);
            test.InsertFront(3);

            test.GetNext();
            var result = test.GetNext();

            Assert.AreEqual(2, 2);
        }
        [Test]
        public void test_itearation_next_list_empty()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            

            test.GetNext();
            var result = test.GetNext();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void test_itearation_next_list_one_item()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertFront(1);

            
            var result = test.GetNext();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void test_itearation_prev_list_one_item()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);

            Assert.AreEqual(1,test.headNode.data);
        }
        [Test]
        public void test_itearation_prev_list_three_item()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            Assert.AreEqual(3, test.headNode.next.next.data);
        }

        [Test]
        public void test_add_back()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.AddNode(1);
            test.AddNode(2);
            test.InsertBack(3);

            Assert.AreEqual(test.headNode.data,1);
        }

        [Test]
        public void test_add_back_value()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.AddNode(1);
            test.AddNode(2);
            test.InsertBack(3);

            Assert.AreEqual(test.currentNode.data, 3);
        }

        [Test]
        public void testdelete_item()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            test.Delete(2);

            Assert.AreEqual(2, test.Lenght);
        }

        [Test]
        public void testdelete_head()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            test.Delete(1);

            Assert.AreEqual(2, test.Lenght);
        }

        [Test]
        public void test_find()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            var result = test.FindNode(3);

            Assert.AreEqual(3, result.data);
        }

        [Test]
        public void test_find_head()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            var result = test.FindNode(1);

            Assert.AreEqual(1, result.data);
        }

        [Test]
        public void test_no_find()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            var result = test.FindNode(4);

            Assert.AreEqual(null, result);
        }

        [Test]
        public void test_reverse_list()
        {
            SingleLinkedList<int> test = new SingleLinkedList<int>();
            test.InsertBack(1);
            test.InsertBack(2);
            test.InsertBack(3);

            test.ReverseLinkList();

            Assert.AreEqual(3,test.headNode.data);
        }
    }
}
