using HelpLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4_01_RouteBetweenNodes
{
    class Implementation
    {
        /// <summary>
        /// Implementation of BFS, the method returns "-1" if no connection between start and end node, or shortest lenght of connecting path.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="start"></param>
        /// <param name="End"></param>
        /// <returns></returns>
        public int search(Graph graph, Node startNode, Node EndNode)
        {
            /*
             enqueue root node and mark as visited
               while queue is not empty
                 dequeue node + visit 
                 foreach adjacent 
                   mark if not already marked + enqueue             
             */

            LinkedList<Node> aNodeList = new LinkedList<Node>();
            aNodeList.AddFirst(startNode);




            return -1;//if not found
        }


    }
}
