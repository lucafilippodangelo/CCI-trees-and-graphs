using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_05_ValidateBST
{
    class Implementation
    {

        public static bool isBSTEntry(Node root)
        {
            if (root == null)
                return true;

            //LD starting from the very min value and max value as low and high boundaries
            return isBSTRecursive(root, int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// APPROACH
        /// 1) visit current node, check that it's value is between boundaries
        /// 2) if left node != null recursively check setting max="current node value". Return false if result of recursive call is != true
        /// 3) if right node != null recursively check setting min="current node value". Return false if result of recursive call is != true
        /// 
        /// with this approach I ensure that current node is smaller or biggr than parent and that the all subtree is balanced
        /// </summary>
        /// <param name="aNode"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static bool isBSTRecursive(Node aNode, int low, int high)
        {
            //LD -> step 1
            if (aNode.LDvalue <= low || aNode.LDvalue  >= high)
                return false;

            //LD -> step 2
            if (aNode.leftPointingNode  != null && !isBSTRecursive(aNode.leftPointingNode , low, aNode.LDvalue  ))
            {
                return false;
            }

            //LD -> step 3
            if (aNode.rightPointingNode  != null && !isBSTRecursive(aNode.rightPointingNode , aNode.LDvalue , high))
            {
                return false;
            }

            return true;
        }

    }
}
