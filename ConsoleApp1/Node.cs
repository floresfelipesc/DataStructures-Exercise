﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTesting
{
    public class Node
    {
        public int data;
        public Node next;
       

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

}