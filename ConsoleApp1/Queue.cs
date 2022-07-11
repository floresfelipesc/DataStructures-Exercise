using System;
using System.Collections.Generic;
using System.Text;


    public class Queue
    {
        public Node front;
        public Node back;

        public Queue()
        {
            front = null;
            back = null;
        }

        public void Enqueue(int n)
        {
            Node desNode = new Node(n);
            //Node temp;

            if(front == null && back == null)
            {
                front = desNode;
                back = desNode;
                return;
            }
            /*
            temp = back;
            back = desNode;
            temp.next = back;
            */
            back.next = desNode;
            back = back.next;

        }

        public void Dequeue()
        {
            if(front == null)
            {
                Console.WriteLine("Queue is currently already empty");
                return;
            }
            if (front.Equals(back))
            {
                front = null;
                back = null;
                return;
            }

            front = front.next;
        }

        public int Peek()
        {
            if(front == null)
            {
                return 0;
            }
            return front.data;
        }

        public void Display()
        {
            if(front == null || back == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            Node curr = front;

            while(curr != null)
            {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }
        }
    }

