using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_03_ListOfDepths
{
    class Implementation
    {
        //LD Entry method, this will return the list of linked list with inside the nodes of the tree organized by level
        public static List<LinkedList<Node>> listOfDepthsEntry(Node root)
        {
            List<LinkedList<Node>> lists = new List<LinkedList<Node>>();

            listOfDepthsRecursive(root, lists, 0);

            return lists;
        }

        public static void listOfDepthsRecursive(Node aNode, List<LinkedList<Node>> lists, int currentLevel)
        {

        }

    }
}
