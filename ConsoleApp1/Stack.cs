using System;
using System.Collections.Generic;
using System.Text;


    public class Stack
    {
        Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int n)
        {
            Node temp;

            if(top == null)
            {
                top = new Node(n);
                return;
            }

            temp = top;
            top = new Node(n);
            top.next = temp;

        }
        public Node Pop()
        {
            Node temp;

            if(top == null)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }

            temp = new Node(top.data);
            top = top.next;
            return temp;

        }
        public int Peek()
        {
            if(top == null)
            return 0;

            return top.data;
        }

        public void Display()
        {
            Node curr;

            if (top == null)
            {
                Console.WriteLine("The Stack is currently empty");
                return;
            }

            curr = top;
            while(curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }



        }
    }

