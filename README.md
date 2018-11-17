# Trees and Graphs

## 4.1 Routes Between Nodes
Given a directed graph, design an algorithm to find out whether there is a route between two nodes.

SOLUTION:
It's an implemetation of a BFS(Breadth First Search), the problem can be solved with just a simple graphs traversal. We start with one node and check if the other node is found. We have to mark nodes as already visited.

LOGIC:

mark all nodes as not visited
enqueue root node and mark as visited
  while queue is not empty
    dequeue last node + visit 
    foreach qequeued adjacent 
      if not already visited -> mark as visited + enqueue    

**implemented in "//LD Q4_01_RouteBetweenNodes"**