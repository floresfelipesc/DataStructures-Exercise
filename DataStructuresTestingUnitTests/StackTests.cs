using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresTesting;

namespace DataStructuresTestingUnitTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Push_InputValueStackEmpty_ReturnStackFilled()
        {
            //initialize
            int expected = 1;
            int input = 1;
            int actual;

            Stack myStack = new Stack();

            //act
            myStack.Push(input);
            actual = myStack.Peek();
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Push_InputValueStackOccupied_ReturnStackFilled()
        {
            //initialize
            int expected = 2;
            int input1 = 1;
            int input2 = 2;
            int actual;

            Stack myStack = new Stack();
            //act
            myStack.Push(input1);
            myStack.Push(input2);
            actual = myStack.Peek();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Pop_StackOneElement_ReturnEmpty()
        {
            //initialize
            int expected = -1;
            int input = 0;
            int actual;

            Stack myStack = new Stack();
            myStack.Push(input);

            //act
            myStack.Pop();
            actual = myStack.Peek();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Pop_StackSeveralElements_ReturnRestOfElements()
        {
            //initialize
            int expected = 2;
            int actual;

            Stack myStack = new Stack();
            myStack.Push(3);
            myStack.Push(2);
            myStack.Push(1);

            //act
            myStack.Pop();
            actual = myStack.Peek();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
