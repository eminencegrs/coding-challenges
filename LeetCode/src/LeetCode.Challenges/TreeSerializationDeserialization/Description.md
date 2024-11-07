# Serialize and Deserialize Binary Tree (#297)

**Serialization** is the process of converting a data structure or object 
into a format that can be stored (e.g., in a file or memory buffer) 
or transmitted (e.g., across a network connection) 
and later reconstructed in the same or a different computing environment.

**Problem Statement:**  
Design an algorithm to serialize and deserialize a binary tree using pre-order traversal.  
The algorithm should allow for the binary tree to be accurately reconstructed.  
No specific method for serialization or deserialization is required.

## Example:

The binary tree:
```
       5  
     /   \  
    3     2  
   / \   / \  
  @  4  @   @  
    / \  
   @   @  
```

Its string representation: `5;3;@;4;@;@;2;@;@`
