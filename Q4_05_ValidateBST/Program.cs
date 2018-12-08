using HelpLibrary;
using System;

namespace Q4_05_ValidateBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region tree one, root "Node1x"

            Node Node1x = new Node(1); Node1x.LDvalue = 1;
            Node Node3x = new Node(3); Node3x.LDvalue = 3;
            Node Node7x = new Node(7); Node7x.LDvalue = 7;


            //LD setup of the tree just by connecting the nodes

            Node1x.rightPointingNode = Node3x;
            Node3x.rightPointingNode = Node7x;

            #endregion

            #region tree two, root "Node20"

            Node Node5 = new Node(5); Node5.LDvalue = 5;
            Node Node6 = new Node(6); Node6.LDvalue = 6;
            Node Node10 = new Node(10); Node10.LDvalue = 10;
            Node Node20 = new Node(20); Node20.LDvalue = 20;
            Node Node25 = new Node(25); Node25.LDvalue = 25;
            Node Node30 = new Node(30); Node30.LDvalue = 30;
            

            //LD setup of the tree just by connecting the nodes

            Node20.leftPointingNode = Node10;
            Node20.rightPointingNode = Node30;

            Node10.leftPointingNode = Node5;
            Node10.rightPointingNode = Node25;

            Node5.rightPointingNode = Node6;

            #endregion

            #region tree two, root "Node20f". Same tree as above but replacing node 25 with 11 in order to respect property

            Node Node5f = new Node(5); Node5f.LDvalue = 5;
            Node Node6f = new Node(6); Node6f.LDvalue = 6;
            Node Node10f = new Node(10); Node10f.LDvalue = 10;
            Node Node20f = new Node(20); Node20f.LDvalue = 20;
            Node Node11f= new Node(11); Node11f.LDvalue = 11;
            Node Node30f = new Node(30); Node30f.LDvalue = 30;


            //LD setup of the tree just by connecting the nodes

            Node20f.leftPointingNode = Node10f;
            Node20f.rightPointingNode = Node30f;

            Node10f.leftPointingNode = Node5f;
            Node10f.rightPointingNode = Node11f;

            Node5f.rightPointingNode = Node6f;

            #endregion


            //LD TESTS ------------------
            bool result;
            result = Implementation.isBSTEntry(Node1x); // tree one expected: TRUE
            result = Implementation.isBSTEntry(Node20); // tree two expected: FALSE
            result = Implementation.isBSTEntry(Node20f); // tree two expected: TRUE
        }
    }
}
