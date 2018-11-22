using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_03_ListOfDepths
{
    class Implementation
    {
        //LD Entry method, will return a list of "LinkedList<Node>", where each linked List cointain nodes for one of the tree levels.
        public static List<LinkedList<Node>> listOfDepthsEntry(Node root)
        {
            List<LinkedList<Node>> listofLinkedList = new List<LinkedList<Node>>();
            listOfDepthsRecursive(root, listofLinkedList, 0);
            return listofLinkedList;
        }

        public static void listOfDepthsRecursive(Node aNode, List<LinkedList<Node>> listofLinkedList, int currentLevel)
        {
            // implementation of DFS, but in this case I don't visit all the adjacent but will go for "Pre Order Traversal" -> visit current(root first time) then left recursively then right recursively
            if (aNode == null) //LD this check is just for the root
                return;

            //LD mark the node as visited
            aNode.visited = true;

            //LD add the node in a linked list
            addNodeToLinkedList(aNode, listofLinkedList, currentLevel);

            if (aNode.leftPointingNode != null && aNode.leftPointingNode.visited == false)
                listOfDepthsRecursive(aNode.leftPointingNode, listofLinkedList, currentLevel + 1);
            if (aNode.rightPointingNode != null && aNode.rightPointingNode.visited == false)
                listOfDepthsRecursive(aNode.rightPointingNode , listofLinkedList, currentLevel + 1);

        }

        public static void addNodeToLinkedList(Node aNode, List<LinkedList<Node>> listofLinkedList, int currentLevel)
        {
            //LD create Linked List for current level if already not exist
            insertCurrentLevelLinkedListIfNotExist(listofLinkedList, currentLevel);

            listofLinkedList[currentLevel].AddFirst(aNode);
        }

        public static void insertCurrentLevelLinkedListIfNotExist(List<LinkedList<Node>> listofLinkedList, int currentLevel)
        {
            // Once I can't check if in a "list" the specific index exist I did implement the below code as a workaround.
            // position zero of "listofLinkedList" represent all the nodes of the tree at level zero. I know as well that
            // all the level will be created in sequence, because of "Deep first search". So if index 2 exists then 0 and 1 must exist because already created.
            // the strategy is to loop on all the "linkedLists" in "listofLinkedList" and check if the specific current level already exists.
            for (var i = 0; i< listofLinkedList.Count ; i++)
            {
                if (i == currentLevel)
                    return;
            }

            //LD if index not found then create and insert a new Linked List for the specific "currentLevel"
            LinkedList<Node> aLinkedList = new LinkedList<Node>();
            listofLinkedList.Insert(currentLevel, aLinkedList);
        }


    }
}
