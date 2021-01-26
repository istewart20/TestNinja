using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void Setup()
        { 
            _stack = new Stack<string>();
        }

        [Test]
        public void Push_NullArgument_ReturnsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidString_ReturnsCountOfOne()
        {
            _stack.Push("test");
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push_TwoValidString_ReturnsCountOfTwo()
        {
            _stack.Push("test");
            _stack.Push("test");
            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Pop_CalledWhenStackIsEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.TypeOf<System.InvalidOperationException>());
        }

        [Test]
        public void Pop_CalledWithOneItemOnStack_ReturnsThatItem()
        {
            var testItem = "test";
            _stack.Push(testItem);
            var result = _stack.Pop();
            Assert.That(result, Is.EqualTo(testItem));
        }

        [Test]
        public void Pop_CalledWithOneItemOnStack_ReturnsCountOfZero()
        {
            var testItem = "test";
            _stack.Push(testItem);
            _stack.Pop();
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_CalledWithTwoItemsOnStack_ReturnsLastItem()
        {
            var testItem1 = "test1";
            var testItem2 = "test2";
            _stack.Push(testItem1);
            _stack.Push(testItem2);
            var result = _stack.Pop();
            Assert.That(result, Is.EqualTo(testItem2));
        }

        [Test]
        public void Pop_CalledWithTwoItemsOnStack_ReturnsCountOfOne()
        {
            var testItem1 = "test1";
            var testItem2 = "test2";
            _stack.Push(testItem1);
            _stack.Push(testItem2);
            _stack.Pop();
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_CalledWhenStackIsEmpty_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.TypeOf<System.InvalidOperationException>());
        }

        [Test]
        public void Peek_CalledWithOneItemOnStack_ReturnsThatItem()
        {
            var testItem = "test";
            _stack.Push(testItem);
            var result = _stack.Peek();
            Assert.That(result, Is.EqualTo(testItem));
        }

        [Test]
        public void Peek_CalledWithTwoItemsOnStack_ReturnsLastItem()
        {
            var testItem1 = "test1";
            var testItem2 = "test2";
            _stack.Push(testItem1);
            _stack.Push(testItem2);
            var result = _stack.Peek();
            Assert.That(result, Is.EqualTo(testItem2));
        }

    }
}
