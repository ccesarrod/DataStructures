using datastructres;
using NUnit.Framework;

namespace TestData
{
    public class BaseClass
    {
        public BinaryTree tree;
        [SetUp]
        public void BaseSetUp()
        {

            BinaryTree tree = new BinaryTree();
            tree.Insert(52);
            tree.Insert(65);
            tree.Insert(33);
            tree.Insert(25);
            tree.Insert(12);
            tree.Insert(27);
        }


    }

    [TestFixture]
    public class TestBinarySearchTree
    {
        private BinaryTree tree;
        [SetUp]
        public void LoadTree()
        {
            tree = new BinaryTree();
            tree.Insert(52);
            tree.Insert(65);
            tree.Insert(33);
            tree.Insert(39);
            tree.Insert(34);
            tree.Insert(48);
            tree.Insert(25);
            tree.Insert(12);
            tree.Insert(27);
            tree.Insert(60);
            tree.Insert(78);
            tree.Insert(90);
            tree.Insert(72);
            tree.Insert(70);
        }

        [Test]
        public void test_insert_root()
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(52);


            Assert.AreEqual(52, tree.Find(52).Value);
        }

        [Test]
        public void test_insert_bigger()
        {
            Assert.AreEqual(65, tree.Find(65).Value);
        }

        [Test]
        public void test_insert_smaller()
        {
            Assert.AreEqual(27, tree.Find(27).Value);
        }

        [Test]
        public void test_delete_leaf_node()
        {
            //leaf node no child
            tree.Delete(12);

            Assert.IsNull(tree.Find(12));
        }

        [Test]
        public void test_delete_node_one_child()
        {
            //leaf node one  child 72 has a node 70
            tree.Delete(72);

            Assert.IsNull(tree.Find(72));

            Assert.AreEqual(70, tree.Find(70).Value);
        }

        [Test]
        public void test_smallest_value()
        {                  

            Assert.AreEqual(12, tree.Smallest());
        }

      
    }
}
