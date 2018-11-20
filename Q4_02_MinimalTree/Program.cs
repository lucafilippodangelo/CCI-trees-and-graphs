using HelpLibrary;
using System;

namespace Q4_02_MinimalTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph Graph1 = new Graph();

            //LD test odd array
            int[] orderedSeq = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Implementation.createMinimalBinarySearchTreeEntry(orderedSeq, Graph1);

            //LD test pair array
            int[] orderedSeqTwo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Implementation.createMinimalBinarySearchTreeEntry(orderedSeqTwo, Graph1);
        }
    }
}
