using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresTesting;

namespace DataStructuresTestingUnitTests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Enqueue_QueueEmpty_ReturnOneElement()
        {
            //initialize
            int expected = 1;
            int input = 1;
            int actual;

            Queue myQueue = new Queue();

            //act
            myQueue.Enqueue(input);
            actual = myQueue.Peek();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Enqueue_QueueSeveralElements_ReturnElements()
        {
            //initialize
            int input1 = 1;
            int input2 = 2;

            int expected1 = 1;
            int expected2 = 2;

            int actual1;
            int actual2;

            Queue myQueue = new Queue();

            //act
            myQueue.Enqueue(input1);
            myQueue.Enqueue(input2);
            actual1 = myQueue.front.data;
            actual2 = myQueue.back.data;

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void Dequeue_QueueSeveralElements_ReturnEmpty()
        {
            //initialize
            int expected = 2;
            int input1 = 1;
            int input2 = 2;

            int actual;

            Queue myQueue = new Queue();
            myQueue.Enqueue(input1);
            myQueue.Enqueue(input2);



            //act
            myQueue.Dequeue();
            actual = myQueue.Peek();

            //assert
            Assert.AreEqual(expected, actual);
        }
       
    }
}
