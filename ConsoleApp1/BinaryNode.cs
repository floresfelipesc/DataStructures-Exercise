using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTesting
{
    public class BinaryNode
    {
        public int data;
        public BinaryNode leftNode;
        public BinaryNode rightNode;

        public BinaryNode()
        {
            data = -1;
            leftNode = null;
            rightNode = null;
        }

        public BinaryNode(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
    }
}
