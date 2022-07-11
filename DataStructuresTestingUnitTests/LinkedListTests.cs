using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresTesting;

namespace DataStructuresTestingUnitTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Add_IntNodeInputListOccupiedScenario_ReturnSameValue()
        {
            //initialize
            int expectedNum = 5;

            LinkedList actual = new LinkedList();
            Node input1 = new Node(1);
            Node input2 = new Node(5);

            //act
            actual.Add(input1);
            actual.Add(input2);

            //assert
            Assert.AreEqual(expectedNum, actual.GetHead().next.data);
            
        }
        [TestMethod]
        public void Add_IntNodeInputListEmptyScenario_ReturnSameValue()
        {
            //initialize
            int expectedNum = 5;

            LinkedList actual = new LinkedList();
            Node input = new Node(5);

            //act
            actual.Add(input);

            //assert
            Assert.AreEqual(expectedNum, actual.GetHead().data);
        }

        [TestMethod]
        public void Remove_ListEmptyScenario_ReturnErrorMessage()
        {
            //initialize
            LinkedList actual = new LinkedList();
            Node expected = null;

            //act
            actual.Remove(0);

            //assert
            Assert.AreEqual(expected, actual.GetHead());

        }

        [TestMethod]
        public void Remove_InputValueIsHeader_ReturnNull()
        {
            //initialize
            LinkedList actual = new LinkedList();
            actual.Add(new Node(0));
            Node expected = null;

            //act
            actual.Remove(0);

            //assert
            Assert.AreEqual(expected, actual.GetHead());
        }

        [TestMethod]
        public void Remove_ListWithInputValue_ReturnNull()
        {
            //intitialize
            LinkedList actual = new LinkedList();
            Node expected = null;
            actual.Add(new Node(0));
            actual.Add(new Node(1));


            //act
            actual.Remove(1);

            //assert
            Assert.AreEqual(expected, actual.GetHead().next);
 
        }

        [TestMethod]
        public void Remove_ListWithInputValueInMiddle_ReturnNextNode()
        {
            //initialize
            LinkedList actual = new LinkedList();
            actual.Add(new Node(0));
            actual.Add(new Node(1));
            actual.Add(new Node(2));
            int expected = 2;

            //act
            actual.Remove(1);

            //assert
            Assert.AreEqual(expected, actual.GetHead().next.data);
        }


    }
}
