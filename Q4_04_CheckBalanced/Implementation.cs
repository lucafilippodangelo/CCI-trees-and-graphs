using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_04_CheckBalanced
{
    class Implementation
    {
        /// <summary>
        ///- It's a kind of DFS "Post-Order Traversal", having in input the root, the algorithm goes down until the very bottom, before for left and then for right.
        ///  - the exit condition from recursion is when in one of left or right there are not further nodes, in this case I return -1 as "height"
        ///- for each node, when I finish the left and right calls , we check(leftHeight - rightHeight)
        ///  - if difference of absolute is > 1 then we "return", it's an exit condition. 
        ///    - else I return the(max between left and right height) + 1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool checkIfBalancedEntry(Node root)
        {
            return checkIfBalancedRecursive(root) != int.MinValue;
        }

        public static int checkIfBalancedRecursive(Node aNode)
        {
            //LD LEFT NODE recursive visit
            int leftHeight = -1; //LD assuming no left childs for current node
            if (aNode.leftPointingNode != null)
            {
                leftHeight = checkIfBalancedRecursive(aNode.leftPointingNode);
            }
            if (leftHeight == int.MinValue) return int.MinValue; //not leveled subtree previously found



            //LD RIGHT NODE recursive visit
            int rightHeight = -1; //LD assuming no right childs for current node
            if (aNode.rightPointingNode != null)
            {
                rightHeight = checkIfBalancedRecursive(aNode.rightPointingNode);
            }
            if (rightHeight == int.MinValue) return int.MinValue; //not leveled subtree previously found



            //LD CURRENT NODE 
            int heightDifference = leftHeight - rightHeight;
            if (Math.Abs(heightDifference) > 1)
            {
                return int.MinValue; //found not leveled subtree
            }
            else
            {
                return (Math.Max(leftHeight, rightHeight)) + 1;
            }

        }
    }
}
