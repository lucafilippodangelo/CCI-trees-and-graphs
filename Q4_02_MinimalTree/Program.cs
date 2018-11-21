using HelpLibrary;
using System;

namespace Q4_02_MinimalTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD the root node will be returned, it's enough debug on the returned node and dig on left and right pointed nodes

            //LD test odd array
            int[] orderedSeq = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Node aNode = Implementation.createMinimalBinarySearchTreeEntry(orderedSeq);

            //LD test pair array
            int[] orderedSeqTwo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Node aNode2 = Implementation.createMinimalBinarySearchTreeEntry(orderedSeqTwo);
        }
    }
}
