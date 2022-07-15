using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTesting
{
    public class BinaryTree
    {
        public BinaryNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insertion(int data)
        {
            BinaryNode tempNode = new BinaryNode(data);

            if(root == null)
            {
                root = tempNode;
                return;
            }

            tempNode = root;
            BinaryNode previous = new BinaryNode();

            while(tempNode != null)
            {
                previous = tempNode;
                if(data <= tempNode.data)
                {
                    tempNode = tempNode.leftNode;
                }
                else
                {
                    tempNode = tempNode.rightNode;
                }
                
            }

            if(data <= previous.data)
            {
                previous.leftNode = new BinaryNode(data);
            }
            else
            {
                previous.rightNode = new BinaryNode(data);
            }
            
                
           

        }
    }
}
