# Trees and Graphs

## 4.1 Routes Between Nodes
Given a directed graph, design an algorithm to find out whether there is a route between two nodes.

SOLUTION:

It's an implemetation of a BFS(Breadth First Search), the problem can be solved with just a simple graphs traversal, the scope is to visit before all the immediate neighbors. We start with one node and check if the other node is found. We have to mark nodes as already visited.

LOGIC:

- mark all nodes as not visited
- enqueue root node and mark as visited
  - while queue is not empty
    - dequeue last node + visit 
    - foreach qequeued adjacent 
      - if not already visited -> mark as visited + enqueue    

[**implemented in "//LD Q4_01_RouteBetweenNodes"**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_01_RouteBetweenNodes)

## 4.2 Minimal Tree
Given a sorted array(increasing order) with unique integer elements, write an algotithm to create a binary search tree with minimal height

APPROACH:

The idea is to consider each subsection of the array per time, below the logic implemented:
1) at each recursive call insert in the tree as a new node the middle element of the array
   continue if startIndex>endIndex
2) create a recursive call passing the left part of the array
3) create a recursive call passing the right part of the array
4) at each recursive call return the created node when all the recursive calls for the subtrees reach the exit condition

[**implemented in "//LD Q4_02_MinimalTree"**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_02_MinimalTree)

## 4.3 List Of Depths
Given a binary tree, design an algorithm which creates a linked list for all the nodes at each depth.

APPROACH:

What I did was implementation of DFS, but in this case I don't visit all the adjacent, went for "Pre Order Traversal" -> visit current(root first time) then left recursively then right recursively.
I did pass down to the recursive calls the tree level( matching linked List index in my collection) in which to store the "current visiting node".

[**implemented in "//LD Q4_03_ListOfDepths"**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_03_ListOfDepths)  The code is very well commented, did a couple of examples.

## 4.4 Check Balanced
Implement a function to check if a binary tree is balanced. A tree is balanced when the height of the subtrees never differ by more than one.

APPROACH:

- It's a kind of DFS "Post-Order Traversal", having in input the root, the algorithm goes down until the very bottom, before for left and then for right.
  - the exit condition from recursion is when in one of left or right there are not further nodes, in this case I return -1 as "height"
- for each node, when I finish the left and right calls , we check(leftHeight - rightHeight)
  - if difference of absolute is > 1 then I "return", it's an exit condition because not leveled subtree found. 
    - else I return (max between left and right height) + 1

[**implemented in "//LD Q4_04_CheckBalanced"**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_04_CheckBalanced)

## 4.5 Validate BST
Check if the input tree is a BST, Binary Search Tree

APPROACH: got a recursive approach, Pre-Order Traversal. Code commented.

[**implemented in "//LD Q4_05_ValidateBST"**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_05_ValidateBST)

## 4.6 Successor
Find successor of each node in having in input a BST. 

APPROACH: I did solve the problem by implementing an "in-order" traversal.

[**implemented in "//LD Q4_06_Successor"**](https://github.com/lucafilippodangelo/CCI-trees-and-graphs/tree/master/Q4_06_Successor)

## 4.7 Build Order
Having a list of processes and a list of dependencies(that is a list of couple of nodes [a,b] where process "a" must be executed before process "b"), write an algorithm to find build order will allow projects to be built.

EXAMPLE: 
- input
  - projects: a,b,c,d,e,f
  - dependencies: (a,d), (f,b), (b,d), (f,a), (d,c)
- output
  - f,e,a,b,d,c

APPROACH:
1) a possible approach is "topological sort", where
   - (A) find all nodes with no incoming connections, queue in a LIFO in order to be processed in order
   - (B) cut all the connections with other nodes 
   - repeat (A) and (B). It's important to say that if loops in place the approach does not work. 
2) a second possible approach to find the built path by avoiding cycles is by using DFS
   - (A) pick an arbitrary node and perform DFS on it
   - (B) go down and put the leafs, for instance "x" node with not outcome connection, in a FIFO list. They will be the last to be built. Cancel all the incoming connections to "x". Then when going back up from recursion include in the FIFO list the parent of "x".
     - it's important to mark as "Visiting" all the nodes part of the current DFS and then mark the same as "Visited" when included in the FIFO list.
   - repeat (A) and (B) until "not visited" nodes in place.
   
**Not implemented once trivial**

## 4.8 First Common Ancestor
write logic to find First Common Ancestor for two nodes in a binary tree(not necessarely a binary search tree). Avoid storing additional nodes in data structure.

In a binary tree was easy to determine in O(n) where the paths meets
  - option one starting from root to nodes "x" and "y", store both paths in array and compare arrays to find match.
  - option two check recursively starting from root if that stecific starting node is father of both. Check recursively in subnodes if not found.

APPROACH:

Once I don't have a binary tree
  - (1) when the nodes have links to parent
    - use same solution adopted in [**2.7 Intersection between two linked lists"**](https://github.com/lucafilippodangelo/CCI-linked-lists) but without storing in linked lists. In this case I need to trace. This approach takes O(d) time, where "d" is the depth of the deepest node.
	  - (a) by tracing the paths from "x" and "y" to the top
	  - (b) get the difference in depth from leaf to root for both nodes
	  - (c) then comparing starting from the bottom position index of the shorter path and comparing going in direction of the root. When they intersect there is a match. 
  - (2) when nodes have not links to parent
    - create a method to check if the input node is contained in any of the left or right subtrees
	  - then starting from the root node check recursively if both nodes are on the same side(callling for each node the above method)
	    - if yes continue recursively checking on the same side otherwhise go and check on the opposite side. 
      - when will happen that the two sub nodes will not be on the same side, root will be returned as first common ancestor.

RESOURCES:
- https://github.com/careercup/CtCI-6th-Edition-CSharp/blob/master/Ch%2004.%20Trees/Q4_08_LowestCommonAncestorNotBST.cs