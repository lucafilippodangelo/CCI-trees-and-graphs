using System;
using System.Collections.Generic;

namespace HelpLibrary
{
    public class Node
    {
        private int value { get; set; }
        private bool visited { get; set; }
        internal List<Node> pointingTo;
     
        public Node(int value)
        {
            this.value = value;
        }//end constructor

    }// end class

}//end namespace
