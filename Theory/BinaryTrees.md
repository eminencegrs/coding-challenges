# Binary Trees

**A tree is a hierarchical data structure that stores information in the form of hierarchy, 
unlike linear data structures like *linked list*, *stack*, etc. 
A tree contains *nodes/data* and *connections/edges* that do not form a cycle.**

### Terminology

 - **Node:** a basic element that may hold a value or condition, or serve as part of a larger structure.
 - **Root:** the topmost node in a tree, considered the primary ancestor.
 - **Child:** a node directly connected to another node when moving downward from the root, serving as an immediate descendant. 
 - **Parent:** the counterpart of a child; an immediate ancestor of a node.
 - **Leaf:** a node with no children.
 - **Internal Node:** a node with at least one child.
 - **Edge:** the connection between two nodes.
 - **Depth:** the distance between a node and the root node.
 - **Level:** the number of edges between a node and the root, plus one.
 - **Height:** the length of the longest path from a node down to a leaf node.
 - **Breadth:** the number of leaf nodes in the tree.
 - **Subtree:** a structure within a tree, consisting of a node and all its descendants.
 - **Binary Tree:** a tree in which each node has at most two children, known as the left child and the right child.
 - **Binary Search Tree (BST):** a specialized binary tree with specific properties: 
     nodes in the left subtree have keys less than the node’s key, 
     and nodes in the right subtree have keys greater than the node’s key. 
     Both left and right subtrees must themselves be binary search trees.

## Tree Traversal

Tree traversal is the process of navigating through a tree data structure one node at a time, 
performing tasks such as examining or updating the node’s data.  

Tree traversal methods are commonly categorized into two types:  

 - **depth-first search (DFS):** it explores all nodes along a branch before backtracking
 - **breadth-first search (BFS):** it visits all nodes at a given level before progressing to the next level

### Types of Tree Traversal Algorithms

 1. **Inorder traversal:** Visits all nodes inside the left subtree, 
      then visits the current node before visiting any node within the right subtree.

 2. **Preorder traversal:** Visits the current node before visiting any nodes inside left or right subtrees.

 3. **Postorder traversal:** Visits the current node after visiting all the nodes of left and right subtrees.

 4. **Level order traversal:** Visits nodes level-by-level and in left-to-right fashion at the same level.

### Inorder traversal

```csharp
public string SerializeInorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
{
    if (node == null)
    {
        return nullMark;
    }

    var leftSerialized = SerializeInorder(node.Left, delimiter, nullMark);
    var rightSerialized = SerializeInorder(node.Right, delimiter, nullMark);

    return $"{leftSerialized}{delimiter}{node.Value}{delimiter}{rightSerialized}";
}

public class TreeNode
{
    public string Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
```

#### Example:

```
       1
      / \
     2   3
    / \   \
   4   5   6
      / \
     7   8
```

The result of inorder traversal: `#;4;#;2;#;7;#;5;#;8;#;1;#;3;#;6;#`.

<details>
  <summary>Step by step explanation</summary>

- **Step 1**: Start at the root node `1` and move to the left subtree `2`.  
  **Current result**: (no nodes visited yet)

- **Step 2**: At the node `2`, move to its left subtree `4`.  
  **Current result**: (no nodes visited yet)

- **Step 3**: The node `4` has no left child, so visit `4` and add a null marker for the left.  
  **Current result**: `#;4`

- **Step 4**: The node `4` has no right child, so add a null marker after visiting `4`.  
  **Current result**: `#;4;#`

- **Step 5**: Move back up to `2` and visit it.  
  **Current result**: `#;4;#;2`

- **Step 6**: Now move to the right subtree of `2`, which is `5`.  
  **Current result**: `#;4;#;2`

- **Step 7**: At `5`, move to its left child `7`.  
  **Current result**: `#;4;#;2`

- **Step 8**: The node `7` has no left child, so visit `7` and add a null marker for the left.  
  **Current result**: `#;4;#;2;#;7`

- **Step 9**: The node `7` has no right child, so add a null marker after visiting `7`.  
  **Current result**: `#;4;#;2;#;7;#`

- **Step 10**: Move back up to `5` and visit it.  
  **Current result**: `#;4;#;2;#;7;#;5`

- **Step 11**: Move to the right child of `5`, which is `8`.  
  **Current result**: `#;4;#;2;#;7;#;5`

- **Step 12**: The node `8` has no left child, so visit `8` and add a null marker for the left.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8`

- **Step 13**: The node `8` has no right child, so add a null marker after visiting `8`.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#`

- **Step 14**: Move back up to the root node `1` and visit it.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#;1`

- **Step 15**: Move to the right subtree of `1`, which is `3`.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#;1`

- **Step 16**: The node `3` has no left child, so add a null marker before visiting `3`.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#;1;#;3`

- **Step 17**: Now move to the right subtree of `3`, which is `6`.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#;1;#;3`

- **Step 18**: The node `6` has no left child, so visit `6` and add a null marker for the left.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#;1;#;3;#;6`

- **Step 19**: The node `6` has no right child, so add a null marker after visiting `6`.  
  **Current result**: `#;4;#;2;#;7;#;5;#;8;#;1;#;3;#;6;#`

</details>

### Preorder traversal

```csharp
public string SerializePreorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
{
    if (node == null)
    {
        return nullMark;
    }

    var leftSerialized = SerializePreorder(node.Left, delimiter, nullMark);
    var rightSerialized = SerializePreorder(node.Right, delimiter, nullMark);

    return $"{node.Value}{delimiter}{leftSerialized}{delimiter}{rightSerialized}";
}

public class TreeNode
{
    public string Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
```

#### Example:

```
       1
      / \
     2   3
    / \   \
   4   5   6
      / \
     7   8
```

The result of preorder traversal: `1;2;4;#;#;5;7;#;#;8;#;#;3;#;6;#;#`.

<details>
  <summary>Step by step explanation</summary>

- **Step 1**: Start at the root node `1` and visit it.  
  **Current result**: `1`

- **Step 2**: Move to the left node `2`, and visit it.  
  **Current result**: `1;2`

- **Step 3**: Move to the left node `4`, and visit it.  
  **Current result**: `1;2;4`

- **Step 4**: The node `4` has not left child, so add a null marker.  
  **Current result**: `1;2;4;#`

- **Step 5**: The node `4` has not right child, so add a null marker.  
  **Current result**: `1;2;4;#;#`

- **Step 6**: Move to the right child of `2`, which is `5` and visit it.  
  **Current result**: `1;2;4;#;#;5`

- **Step 7**: Move to the left child of `5`, which is `7` and visit it.  
  **Current result**: `1;2;4;#;#;5;7`

- **Step 8**: The node `7` has not left child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#`

- **Step 9**: The node `7` has not right child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#;#`

- **Step 10**: Move to the right child of `5`, which is `8` and visit it.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8`

- **Step 11**: The node `8` has not left child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#`

- **Step 12**: The node `8` has not right child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#;#`

- **Step 13**: Move to the right child of `1`, which is `3` and visit it.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#;#;3`

- **Step 14**: The node `3` has not left child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#;#;3;#`

- **Step 15**: Move to the right child of `3`, which is `6` and visit it.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#;#;3;#;6`

- **Step 16**: The node `6` has not left child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#;#;3;#;6;#`

- **Step 17**: The node `6` has not right child, so add a null marker.  
  **Current result**: `1;2;4;#;#;5;7;#;#;8;#;#;3;#;6;#;#`

</details>

### Postorder traversal

```csharp
public string SerializePostorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
{
    if (node == null)
    {
        return nullMark;
    }

    var leftSerialized = SerializePostorder(node.Left, delimiter, nullMark);
    var rightSerialized = SerializePostorder(node.Right, delimiter, nullMark);

    return $"{leftSerialized}{delimiter}{rightSerialized}{delimiter}{node.Value}";
}

public class TreeNode
{
    public string Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
```

#### Example:

```
       1
      / \
     2   3
    / \   \
   4   5   6
      / \
     7   8
```

The result of postorder traversal: `#;#;4;#;#;7;#;#;8;5;2;#;#;#;6;3;1`.

<details>
  <summary>Step by step explanation</summary>

- **Step 1**: Start at the root node `1` and move to the left subtree `2`.  
  **Current result**: (no nodes visited yet)

- **Step 2**: At the node `2`, move to its left subtree `4`.  
  **Current result**: (no nodes visited yet)

- **Step 3**: The node `4` has no left child, so add a null marker for the left.  
  **Current result**: `#`

- **Step 4**: The node `4` has no right child, so add a null marker for the right.  
  **Current result**: `#;#`

- **Step 5**: Move back up to `4` and visit it.  
  **Current result**: `#;#;4`

- **Step 6**: Now move to the right subtree of `2`, which is `5`.  
  **Current result**: `#;#;4`

- **Step 7**: Move to the left subtree of `5`, which is `7`.  
  **Current result**: `#;#;4`

- **Step 8**: The node `7` has no left child, so add a null marker for the left.  
  **Current result**: `#;#;4;#`

- **Step 9**: The node `7` has no right child, so add a null marker for the right.  
  **Current result**: `#;#;4;#;#`

- **Step 10**: Move back up to the node `7` and visit it.  
  **Current result**: `#;#;4;#;#;7`

- **Step 11**: Now move to the right subtree of `5`, which is `8`.  
  **Current result**: `#;#;4;#;#;7`

- **Step 12**: The node `8` has no left child, so add a null marker for the left.  
  **Current result**: `#;#;4;#;#;7;#`

- **Step 13**: The node `8` has no right child, so add a null marker for the right.  
  **Current result**: `#;#;4;#;#;7;#;#`

- **Step 14**: Move back up to the node `8` and visit it.  
  **Current result**: `#;#;4;#;#;7;#;#;8`

- **Step 15**: Move back up to the node `5` and visit it.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;`

- **Step 16**: Move back up to the node `2` and visit it.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2`

- **Step 17**: Now move to the right subtree of `1`, which is `3`.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2`

- **Step 18**: The node `3` has no left child, so add a null marker for the left.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#`

- **Step 19**: Now move to the right subtree of `3`, which is `6`.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#`

- **Step 20**: The node `6` has no left child, so add a null marker for the left.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#;#`

- **Step 21**: The node `6` has no right child, so add a null marker for the right.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#;#;#`

- **Step 22**: Move back up to the node `6` and visit it.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#;#;#;6`

- **Step 23**: Move back up to the node `3` and visit it.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#;#;#;6;3`

- **Step 24**: Move back up to the node `1` and visit it.  
  **Current result**: `#;#;4;#;#;7;#;#;8;5;2;#;#;#;6;3;1`

</details>

### Level order traversal

```csharp
public string SerializeLevelOrder(TreeNode? node, string delimiter = ";", string nullMark = "#")
{
    if (node == null)
    {
        return nullMark;
    }

    var result = new List<string>();
    var queue = new Queue<TreeNode?>();

    // Add the current root.
    queue.Enqueue(node);

    while (queue.Count > 0)
    {
        var currentNode = queue.Dequeue();
        if (currentNode == null)
        {
            result.Add(nullMark);
        }
        else
        {
            result.Add(currentNode.Value);

            // Enqueue left and right children to process the next level in a proper order.
            queue.Enqueue(currentNode.Left);
            queue.Enqueue(currentNode.Right);
        }
    }

    return string.Join(delimiter, result);
}

public class TreeNode
{
    public string Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
```

#### Example:

```
       1
      / \
     2   3
    / \   \
   4   5   6
      / \
     7   8
```

The result of level order traversal: `1;2;3;4;5;#;6;#;#;7;8;#;#;#;#;#;#`.

<details>
  <summary>Step by step explanation</summary>

- **Step 1**: Start at the root node `1` and enqueue it into the queue.  
  **Current result**: (no nodes visited yet)  
  **Queue**: `[1]`

- **Step 2**: Dequeue node `1` and process it. Add its value to the result list, 
              and enqueue its left `2` and right `3` children for future processing.  
  **Current result**: `1`  
  **Queue**: `[2, 3]`

- **Step 3**: Dequeue node `2` and process it. Add its value to the result list, 
              and enqueue its left `4` and right `5` children for future processing.  
  **Current result**: `1;2`  
  **Queue**: `[3, 4, 5]`

- **Step 4**: Dequeue node `3` and process it. Add its value to the result list, 
              and enqueue its left `null` and right `6` children for future processing.  
  **Current result**: `1;2;3`  
  **Queue**: `[4, 5, null, 6]`

- **Step 5**: Dequeue node `4` and process it. Add its value to the result list, 
              and enqueue its left `null` and right `null` children for future processing.  
  **Current result**: `1;2;3;4`  
  **Queue**: `[5, null, 6, null, null]`

- **Step 6**: Dequeue node `5` and process it. Add its value to the result list, 
              and enqueue its left `7` and right `8` children for future processing.  
  **Current result**: `1;2;3;4;5`  
  **Queue**: `[null, 6, null, null, 7, 8]`

- **Step 7**: Dequeue node `null` (left child of `3`) and process it. 
              Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#`  
  **Queue**: `[6, null, null, 7, 8]`

- **Step 8**: Dequeue node `6` and process it. Add its value to the result list, 
              and enqueue its left `null` and right `null` children for future processing.  
  **Current result**: `1;2;3;4;5;#;6`  
  **Queue**: `[null, null, 7, 8, null, null]`

- **Step 9**: Dequeue node `null` (left child of `6`) and process it. 
              Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#`  
  **Queue**: `[null, 7, 8, null, null]`

- **Step 10**: Dequeue node `null` (right child of `6`) and process it. 
               Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#`  
  **Queue**: `[7, 8, null, null]`

- **Step 11**: Dequeue node `7` and process it. Add its value to the result list, 
               and enqueue its left `null` and right `null` children for future processing.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7`  
  **Queue**: `[8, null, null, null, null]`

- **Step 12**: Dequeue node `8` and process it. Add its value to the result list, 
               and enqueue its left `null` and right `null` children for future processing.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8`  
  **Queue**: `[null, null, null, null, null, null]`

- **Step 13**: Dequeue node `null` (left child of `7`) and process it. 
               Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8;#`  
  **Queue**: `[null, null, null, null]`

- **Step 14**: Dequeue node `null` (right child of `7`) and process it. 
               Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8;#;#`  
  **Queue**: `[null, null, null]`

- **Step 15**: Dequeue node `null` (left child of `8`) and process it. 
               Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8;#;#;#`  
  **Queue**: `[null, null, null]`

- **Step 16**: Dequeue node `null` (right child of `8`) and process it. 
               Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8;#;#;#;#`  
  **Queue**: `[null, null]`

- **Step 17**: Dequeue node `null` and process it. Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8;#;#;#;#;#`  
  **Queue**: `[null]`

- **Step 18**: Dequeue node `null` and process it. Add the null marker `#` to the result list.  
  **Current result**: `1;2;3;4;5;#;6;#;#;7;8;#;#;#;#;#;#`  
  **Queue**: `[]`

- **Step 19**: The queue is empty, so the function ends. 
               The result is joined with the delimiter `;` and returned as the final serialized string:  
  **Final result**: `1;2;3;4;5;#;6;#;#;7;8;#;#;#;#;#;#`

</details>

## Tree Depth

 - The **depth** of a binary tree is the number of edges on the path from the root to a given node.
 - The **max depth** of a binary tree is the length of the longest path from the root node to any leaf node.

The **max depth** of a binary tree can be computed recursively:

1. If the tree is empty (no nodes, the root node is `null`), then the max depth is `0`.
2. Otherwise: `MaxDepth = 1 + Math.Max(MaxDepth(root.Left), MaxDepth(root.Right))

#### Example:

```
        1
       / \
      2   3
     / \
    4   5
```

The max depth of this tree is **3**.
