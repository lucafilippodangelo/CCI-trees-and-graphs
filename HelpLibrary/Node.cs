using System;
using System.Collections.Generic;

namespace HelpLibrary
{
    public class Node
    {
        public int LDvalue { get; set; }
        public bool visited { get; set; }
        public List<Node> pointingTo;
     
        public Node(int value)
        {
            this.LDvalue = value;
        }//end constructor

    }// end class

}//end namespace
