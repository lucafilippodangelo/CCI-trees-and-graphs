using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_06_Successor
{
    class Implementation
    {
        static List<int> aListOfNodes = new List<int> ();

        /// <summary>
        /// In Order Recursive traversal Implementation
        /// 1) traverse the left subtree, go as deep as possible on left branch 
        /// 2) then visit current if no more left
        /// 3) then visit right subtree
        /// </summary>
        /// <param name="aNode"></param>
        /// <returns></returns>
        public static List<int> successorsList(Node aNode)
        {
            //LD step 1
            if (aNode.leftPointingNode != null)
            {
                successorsList(aNode.leftPointingNode);
            }

            //LD step 2
            aListOfNodes.Add(aNode.LDvalue);

            //LD step 3
            if (aNode.rightPointingNode != null)
            {
                successorsList(aNode.rightPointingNode);
            }

            return aListOfNodes;
        }
    }
}