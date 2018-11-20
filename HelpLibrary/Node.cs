using System;
using System.Collections.Generic;

namespace HelpLibrary
{
    public class Node
    {
        public int LDvalue { get; set; }
        public bool visited { get; set; }

        //property useful for directed graphs
        public List<Node> pointingTo; 

        //property useful for balanced trees
        public Node leftPointingNode { get; set; }
        public Node rightPointingNode { get; set; }

        public Node(int value)
        {
            this.LDvalue = value;
        }//end constructor

    }// end class

}//end namespace
