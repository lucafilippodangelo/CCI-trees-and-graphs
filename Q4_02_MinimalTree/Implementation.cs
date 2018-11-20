using HelpLibrary;

namespace Q4_02_MinimalTree
{
    class Implementation
    {


        public static void createMinimalBinarySearchTreeEntry(int[] orderedSeq, Graph Graph1)
        {
            //LD for each sequence consider from index 0 to lenght-1
            int startIndex = 0;
            int endIndex = orderedSeq.Length - 1;

            
            Node aa = createMinimalBinarySearchTreeRecursive(orderedSeq, startIndex, endIndex);

            Graph1.Nodes.Add(aa);



        }

        /// <summary>
        /// The idea is to consider each subsection of the array per time:
        /// 1) insert in the tree the middle element of the array
        /// 2) insert into the left of the subtree the left part of the array
        /// 3) insert into the right of the subtree the right part of the array
        /// 4) recurse
        /// </summary>
        /// <param name="orderedSeq"></param>
        public static Node createMinimalBinarySearchTreeRecursive(int[] orderedSeq, int startIndex, int endIndex)
        {
            //LD recursion exit condition
            if (endIndex < startIndex)
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
