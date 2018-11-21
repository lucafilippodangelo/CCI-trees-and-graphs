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

**implemented in "//LD Q4_01_RouteBetweenNodes"**

## 4.2 Minimal Tree
Given a sorted array(increasing order) with unique integer elements, write an algotithm to create a binary search tree with minimal height

APPROACH:

The idea is to consider each subsection of the array per time, below the logic implemented:
1) at each recursive call insert in the tree as a new node the middle element of the array
   continue if startIndex>endIndex
2) create a recursive call passing the left part of the array
3) create a recursive call passing the right part of the array
4) at each recursive call return the created node when all the recursive calls for the subtrees reach the exit condition

**implemented in "//LD Q4_02_MinimalTree"**

## 4.3 List Of Depths
Given a binary tree, design an algorithm which creates a linked list for all the nodes at each depth.

APPROACH:

Here the idea is to solve the problem with a DFS(Deep First Search), a kind of preorder traversal, where the root is the first visited. I need to pass down to the recursive calls the level in order to store the element in the proper queue.

Help Methods Needed that I will not create because out of the scope:
- method to create a list for each depth level of the three(check inside if the specific list exist already before to create)
- method to chech the dept of the tree


- method to add the input node in the specific list


- method to create the tree receiving in input the root


