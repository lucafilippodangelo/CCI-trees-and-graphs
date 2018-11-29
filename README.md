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

APPROACH:

- OPTION 1 -> do a In-Order DFS, copy all the content of the tree in an array and then check if the array is ordered. An improvement could be to don't use the array, keep in a static variable the last visited node in order to compare it with the current.
- OPTION 2 -> I went for a DFS implementation. An in-order search respecting in all the tree was "left <= current < right"