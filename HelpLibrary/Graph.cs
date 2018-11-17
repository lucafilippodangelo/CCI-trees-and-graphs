using System;
using System.Collections.Generic;
using System.Text;

namespace HelpLibrary
{
    //LD repesenting a graph using Adjacency List
    public class Graph
    {
        public List<Node> Nodes;

        public void nodePointTo(Node aNode, List<Node> pointedNodes)
        {
            aNode.pointingTo = pointedNodes;
        }

    }
}
