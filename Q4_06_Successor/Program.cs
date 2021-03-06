﻿using HelpLibrary;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Q4_06_Successor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.6 Successor - Execution!");

            #region Creation tree with four levels. I can pass to the method the root "Node1"

            Node Node1 = new Node(1); Node1.LDvalue = 1;
            Node Node2 = new Node(2); Node2.LDvalue = 2;
            Node Node3 = new Node(3); Node3.LDvalue = 3;
            Node Node4 = new Node(4); Node4.LDvalue = 4;
            Node Node5 = new Node(5); Node5.LDvalue = 5;
            Node Node6 = new Node(6); Node6.LDvalue = 6;
            Node Node7 = new Node(7); Node7.LDvalue = 7;
            Node Node75 = new Node(75); Node75.LDvalue = 75;
            Node Node80 = new Node(80); Node80.LDvalue = 80;
            Node Node90 = new Node(90); Node90.LDvalue = 90;
            Node Node100 = new Node(100); Node100.LDvalue = 100;

            //LD setup of the tree just by connecting the nodes

            Node5.rightPointingNode  = Node6;

            Node2.leftPointingNode = Node1;
            Node2.rightPointingNode = Node3;

            Node4.leftPointingNode = Node2;
            Node4.rightPointingNode = Node5;

            Node7.leftPointingNode = Node4;
            Node7.rightPointingNode = Node80;

            Node80.leftPointingNode = Node75;
            Node80.rightPointingNode = Node90;

            Node90.rightPointingNode = Node100;

            #endregion

            List<int> result = Implementation.successorsList(Node7); // passing the root, Expected the result of an "in-order" recursive traversal.

        }
    }
}
