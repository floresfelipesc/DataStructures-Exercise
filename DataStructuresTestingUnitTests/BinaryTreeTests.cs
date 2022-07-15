using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresTesting;

namespace DataStructuresTestingUnitTests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void Insertion_TreeEmpty_ReturnSuccess(){
            //initialize
            BinaryTree myTree = new BinaryTree();
            int expected = 1;
            int actual = -1;
            int input = 1;
            //act
            myTree.Insertion(input);
            actual = myTree.root.data;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Insertion_TreeOccupied_ReturnSuccess()
        {
            //initialize
            BinaryTree myTree = new BinaryTree();
            int expected = 2;
            int actual;

            //act
            myTree.Insertion(1);
            myTree.Insertion(2);
            actual = myTree.root.rightNode.data;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
