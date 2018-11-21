using HelpLibrary;

namespace Q4_02_MinimalTree
{
    class Implementation
    {


        public static Node createMinimalBinarySearchTreeEntry(int[] orderedSeq)
        {
            //LD for each sequence consider from index 0 to lenght-1
            int startIndex = 0;
            int endIndex = orderedSeq.Length - 1;

            return createMinimalBinarySearchTreeRecursive(orderedSeq, startIndex, endIndex);
        }

        /// <summary>
        /// The idea is to consider each subsection of the array per time:
        /// 1) at each recursive call insert in the tree as a new node the middle element of the array
        ///    continue if startIndex>endIndex
        /// 2) create a recursive call passing the left part of the array
        /// 3) create a recursive call passing the right part of the array
        /// 4) at each recursive call return the created node when all the recursive calls for the subtrees reach the exit condition
        /// </summary>
        /// <param name="orderedSeq"></param>
        public static Node createMinimalBinarySearchTreeRecursive(int[] orderedSeq, int startIndex, int endIndex)
        {
            //LD recursion exit condition
            if ( startIndex > endIndex )
                return null;

            //LD for each sequence consider from index 0 to lenght-1
            int midElementIndex = (startIndex+endIndex) / 2;

            Node Node1 = new Node(orderedSeq[midElementIndex]);
            //aGraph.Nodes.Add(Node1);

            Node1.leftPointingNode = createMinimalBinarySearchTreeRecursive(orderedSeq, startIndex, midElementIndex - 1);
            Node1.rightPointingNode = createMinimalBinarySearchTreeRecursive(orderedSeq, midElementIndex + 1, endIndex);

            return Node1;

        }


    }
}
