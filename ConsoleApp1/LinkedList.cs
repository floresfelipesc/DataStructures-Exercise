using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTesting
{
    public class LinkedList
    {
        private Node header;

        public LinkedList()
        {
            header = null;
        }

        public Node GetHead()
        {
            return header;
        }

        public bool Add(Node desired)
        {
            Node temp = header;
            if (header == null)
            {
                header = desired;
                return true;
            }
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = desired;
            return true;
        }

        public void Display()
        {
            Node temp = header;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }

        public void Remove(int desired)
        {
            Node curr = header;

            if (header == null)
            {
                Console.WriteLine("Linked List is Empty! Nothing can be removed");
                return;
            }

            if (curr.data == desired)
            {
                header = header.next;
                return;
            }

            Node previous = header;
            curr = curr.next;
            Node after = curr.next;

            while (curr != null)
            {

                //Node after = curr.next;
                //node offset
                if (curr.data == desired)
                {
                    //skip node
                    previous.next = after;
                    return;
                }
                else
                {
                    //update positions
                    previous = previous.next;
                    curr = curr.next;
                    after = after.next;
                }
            }
        }

    }
}
