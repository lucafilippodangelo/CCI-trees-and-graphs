using System;

namespace Q4_05_ValidateBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Creation of easiest tree to show the algorithm working. I can pass to the method the root "Node1x"

            Node Node1x = new Node(1); Node1x.LDvalue = 1;
            Node Node3x = new Node(3); Node3x.LDvalue = 3;
            Node Node7x = new Node(7); Node7x.LDvalue = 7;


            //LD setup of the tree just by connecting the nodes

            Node1x.rightPointingNode = Node3x;
            Node3x.rightPointingNode = Node7x;

            #endregion

            #region Creation tree with four levels. I can pass to the method the root "Node1"

            Node Node1 = new Node(1); Node1.LDvalue = 1;
            Node Node2 = new Node(2); Node2.LDvalue = 2;
            Node Node3 = new Node(3); Node3.LDvalue = 3;
            Node Node4 = new Node(4); Node4.LDvalue = 4;
            Node Node5 = new Node(5); Node5.LDvalue = 5;
            Node Node6 = new Node(6); Node6.LDvalue = 6;
            Node Node7 = new Node(7); Node7.LDvalue = 7;
            Node Node9 = new Node(9); Node9.LDvalue = 9;
            Node Node10 = new Node(10); Node10.LDvalue = 10;
            Node Node12 = new Node(12); Node12.LDvalue = 12;

            //LD setup of the tree just by connecting the nodes

            Node1.leftPointingNode = Node2;
            Node1.rightPointingNode = Node3;

            Node2.leftPointingNode = Node4;
            Node2.rightPointingNode = Node5;

            Node3.leftPointingNode = Node6;
            Node3.rightPointingNode = Node7;

            Node7.leftPointingNode = Node9;
            Node7.rightPointingNode = Node10;

            Node10.rightPointingNode = Node12;

            #endregion

            #region Creation tree with five levels. I can pass to the method the root "Node1a"

            Node Node1a = new Node(1); Node1a.LDvalue = 1;
            Node Node2a = new Node(2); Node2a.LDvalue = 2;
            Node Node3a = new Node(3); Node3a.LDvalue = 3;
            Node Node4a = new Node(4); Node4a.LDvalue = 4;
            Node Node5a = new Node(5); Node5a.LDvalue = 5;
            Node Node6a = new Node(6); Node6a.LDvalue = 6;
            Node Node7a = new Node(7); Node7a.LDvalue = 7;
            Node Node9a = new Node(9); Node7a.LDvalue = 9;
            Node Node10a = new Node(10); Node10a.LDvalue = 10;


            //LD setup of the tree just by connecting the nodes

            Node1a.leftPointingNode = Node2a;
            Node1a.rightPointingNode = Node3a;

            Node2a.leftPointingNode = Node4a;
            Node2a.rightPointingNode = Node5a;

            Node3a.leftPointingNode = Node6a;
            Node3a.rightPointingNode = Node7a;

            Node7a.leftPointingNode = Node9a;
            Node7a.rightPointingNode = Node10a;

            #endregion


            //LD TESTS ------------------
            bool result;
            result = Implementation.checkIfBalancedEntry(Node1x); // expected: FALSE, not balanced (2 levels of difference)
            result = Implementation.checkIfBalancedEntry(Node1); // expected: FALSE, not balanced (2 levels of difference)
            result = Implementation.checkIfBalancedEntry(Node1a); // expected: TRUE, balanced (1 level of difference)
        }
    }
}
