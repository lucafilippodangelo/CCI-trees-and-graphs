using HelpLibrary;

namespace Q4_08_FirstCommonAncestor
{
    class Implementation
    {

        static public Node FirstCommonAncestor(Node root, Node p, Node q)
        {
            //LD the tree must have both the nodes
            if (!nodeInRootSubtreeRec(root, p) || !nodeInRootSubtreeRec(root, q)) return null;

            return FirstCommonAncestorRec(root, p, q);
        }

        static private Node FirstCommonAncestorRec(Node root, Node p, Node q)
        {
            if (root == null) return null;
            if (root == p) return root;
            if (root == q) return root;

            //LD check if both the nodes are on the same subtree, Left in this case
            var pIsOnLeft = nodeInRootSubtreeRec(root.leftPointingNode, p);
            var qIsOnLeft = nodeInRootSubtreeRec(root.leftPointingNode, q);

            //LD if they are not, FirstCommon Ancestor found
            if (pIsOnLeft != qIsOnLeft) return root;

            //LD if they are keep investigating on left side otherwhise investigate on right side
            if (pIsOnLeft && qIsOnLeft)
            { return FirstCommonAncestorRec(root.leftPointingNode , p, q); }
            else
            { return FirstCommonAncestorRec(root.rightPointingNode , p, q); }
            
        }

        /// <summary>
        /// Ckeck in all the tree starting from root if the node exists
        /// for each node I check the two childs recursively. 
        ///   - Prior to the recursive call I check 
        ///     - if the current is null, in this case I return false
        ///     - if the node is found, then return true
        /// if found, the true will be passed UP until reach the root. The condition is in or, returns true if one of the two branches got true.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="aNode"></param>
        /// <returns></returns>
        public static bool nodeInRootSubtreeRec(Node root, Node aNode)
        {
            //LD first time I get a true it will be returned up until the root is reached
            if (root == null) return false;
            if (root == aNode) return true;
            return (nodeInRootSubtreeRec(root.leftPointingNode, aNode) || nodeInRootSubtreeRec(root.rightPointingNode, aNode));
        }
    }
}
