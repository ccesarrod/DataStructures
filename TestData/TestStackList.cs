using datastructres;
using NUnit.Framework;

namespace TestData
{
    [TestFixture]
    public class TestStackList
    {
        [Test]
        public void test_add_to_stack()
        {
            StackList<string> stack = new StackList<string>();
            stack.Push("world");

            Assert.AreEqual(1, stack.Count);
        }

        [Test]
        public void test_remove_to_stack()
        {
            StackList<string> stack = new StackList<string>();
            stack.Push("world");
            stack.Push("ocean");

           var value= stack.Pop();

            Assert.AreEqual("ocean", value);
        }

        [Test]
        public void test_remove_empty()
        {
            StackList<string> stack = new StackList<string>();
            stack.Push("world");
            stack.Push("ocean");

            stack.Pop();
            stack.Pop();

            Assert.AreEqual(0,stack.Count);
        }
    }
}
