using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_05_ValidateBST
{
    class Implementation
    {
        static int maxFromLeft;
        static int maxFromRight;
        static int currentFromLeft;
        static int currentFromRight;

        //LD this is a complex approach I got, not sure it is working
        /*
         
        public static int checkBSTRecursive2(Node aNode)
        {
            //LD mark the node as visited
            aNode.visited = true;

            if (aNode.leftPointingNode != null && aNode.leftPointingNode.visited == false)
                maxFromLeft = checkBSTRecursive(aNode.leftPointingNode);

            if (aNode.rightPointingNode != null && aNode.rightPointingNode.visited == false)
                maxFromRight = checkBSTRecursive(aNode.rightPointingNode);

            //LD CHECK if "left<=current<right" in case 

            currentFromLeft = -1;
            currentFromRight = -1;
            if (aNode.leftPointingNode != null && !(aNode.LDvalue >= aNode.leftPointingNode.LDvalue) && !(aNode.LDvalue >= maxFromLeft)) 
            {
                //exit from function, the tree is not balanced  
            }
            else { currentFromLeft = aNode.leftPointingNode.LDvalue; }

            if  (aNode.rightPointingNode != null && !(aNode.LDvalue < aNode.leftPointingNode.LDvalue) && !(aNode.LDvalue < maxFromRight))
            {
                //exit from function, the tree is not balanced
            }
            else { currentFromRight = aNode.rightPointingNode.LDvalue; }


            return Math.Max(currentFromLeft, Math.Max(currentFromRight,aNode.LDvalue )); // at each call return: max between current, left and right
        }

        */



    }
}
