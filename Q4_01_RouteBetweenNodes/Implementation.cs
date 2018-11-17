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
        /// <param name="graph"></param>
        /// <param name="startNode"></param>
        /// <param name="endNode"></param>
        /// <returns></returns>
        public static bool search(Graph graph, Node startNode, Node endNode)
        {
            /*
             mark all nodes as not visited
             enqueue root node and mark as visited
               while queue is not empty
                 dequeue last node + visit 
                 foreach qequeued adjacent 
                   if not already visited -> mark as visited + enqueue             
             */

            foreach (Node aNode in graph.Nodes)
            {aNode.visited = false;}

            //LD add "StartNode" parm to queue and mark as "visited"
            LinkedList<Node> aQueue = new LinkedList<Node>();
            aQueue.AddFirst(startNode);
            startNode.visited = true;

            while (aQueue.Count > 0)
            {
                //LD remove last
                Node removed = aQueue.Last.Value; //LD in the Value property We have the object itself
                aQueue.RemoveLast();

                if (removed == endNode)
                    return true; //found

                if (removed.pointingTo != null)
                {
                    foreach (Node aNode in removed.pointingTo)
                    {
                        if (aNode.visited == false)
                        {
                            aQueue.AddFirst(aNode);
                            aNode.visited = true;
                        }    
                    }
                }
            }
            return false;//not found
        }


    }
}
